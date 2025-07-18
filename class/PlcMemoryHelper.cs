using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Melsec;
using Newtonsoft.Json;

public class PlcMemorySnapshot
{
    public Dictionary<ushort, ushort> W { get; set; } = new Dictionary<ushort, ushort>();
    public Dictionary<ushort, bool> B { get; set; } = new Dictionary<ushort, bool>();
}

public static class PlcMemoryHelper
{
    /// <summary>
    /// 한 번에 Word 영역 블록 읽기 (예: W3000h..)
    /// </summary>
    public static Dictionary<ushort, ushort> ReadWordBlock(MelsecMcServer server, ushort startAddress, ushort count)
    {
        // 십육진수 4자리로 변환하여 주소 생성 (예: W0x0FA0 → "W0FA0")
        string address = $"W{startAddress:X4}";
        var result = server.Read(address, count);  // OperateResult<byte[]>
        if (!result.IsSuccess)
            throw new InvalidOperationException($"W 블록 읽기 실패: {result.Message}");

        byte[] buffer = result.Content;
        if (buffer == null || buffer.Length < count * 2)
            throw new InvalidOperationException("W 블록 읽기 결과가 비어 있거나 예상 길이보다 짧습니다.");

        var dict = new Dictionary<ushort, ushort>(count);
        for (int i = 0; i < count; i++)
        {
            ushort value = BitConverter.ToUInt16(buffer, i * 2);
            dict[(ushort)(startAddress + i)] = value;
        }

        Debug.WriteLine($"ReadWordBlock: 시작=0x{startAddress:X4}, 개수={count}, 읽은 항목={dict.Count}");
        return dict;
    }

    /// <summary>
    /// 한 번에 Bit 영역 블록 읽기 (예: B3000h..)
    /// </summary>
    public static Dictionary<ushort, bool> ReadBitBlock(MelsecMcServer server, ushort startAddress, ushort count)
    {
        string address = $"B{startAddress:X4}";
        var result = server.ReadBool(address, count);  // OperateResult<bool[]>
        if (!result.IsSuccess)
            throw new InvalidOperationException($"B 블록 읽기 실패: {result.Message}");

        bool[] bits = result.Content;
        if (bits == null || bits.Length < count)
            throw new InvalidOperationException("B 블록 읽기 결과가 비어 있거나 예상 길이보다 짧습니다.");

        var dict = new Dictionary<ushort, bool>(count);
        for (int i = 0; i < count; i++)
        {
            dict[(ushort)(startAddress + i)] = bits[i];
        }

        Debug.WriteLine($"ReadBitBlock: 시작=0x{startAddress:X4}, 개수={count}, 읽은 항목={dict.Count}");
        return dict;
    }

    /// <summary>
    /// PLC 메모리 스냅샷 전체 읽기
    /// </summary>
    public static PlcMemorySnapshot ReadSnapshot(MelsecMcServer server,
                                                ushort wStart, ushort wCount,
                                                ushort bStart, ushort bCount)
    {
        var snapshot = new PlcMemorySnapshot
        {
            W = ReadWordBlock(server, wStart, wCount),
            B = ReadBitBlock(server, bStart, bCount)
        };
        Debug.WriteLine($"Snapshot 생성: W 개수={snapshot.W.Count}, B 개수={snapshot.B.Count}");
        return snapshot;
    }

    /// <summary>
    /// 스냅샷을 JSON 파일로 저장
    /// </summary>
    public static void SaveSnapshotToJson(PlcMemorySnapshot snapshot, string filePath)
    {
        Debug.WriteLine($"SaveSnapshotToJson: W={snapshot.W.Count}, B={snapshot.B.Count}, 경로={filePath}");
        string json = JsonConvert.SerializeObject(snapshot, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// JSON 파일에서 PLC 스냅샷 로드
    /// </summary>
    public static PlcMemorySnapshot LoadSnapshotFromJson(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Debug.WriteLine($"LoadSnapshotToJson: 파일 없음 경로={filePath}");
            return new PlcMemorySnapshot();
        }

        string json = File.ReadAllText(filePath);
        var snapshot = JsonConvert.DeserializeObject<PlcMemorySnapshot>(json);
        Debug.WriteLine($"LoadSnapshotToJson: W={(snapshot?.W.Count ?? 0)}, B={(snapshot?.B.Count ?? 0)}");
        return snapshot ?? new PlcMemorySnapshot();
    }

    /// <summary>
    /// PLC 스냅샷을 서버 메모리에 복원
    /// </summary>
    public static void RestoreSnapshotToServer(PlcMemorySnapshot snapshot, MelsecMcServer server)
    {
        foreach (var kvp in snapshot.W)
        {
            string address = $"W{kvp.Key:X4}";
            server.Write(address, kvp.Value);
        }

        foreach (var kvp in snapshot.B)
        {
            string address = $"B{kvp.Key:X4}";
            server.Write(address, kvp.Value);
        }

        Debug.WriteLine($"RestoreSnapshotToServer: 완료 W={snapshot.W.Count}, B={snapshot.B.Count}");
    }


}


