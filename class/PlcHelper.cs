using System;
using System.Threading.Tasks;
using System.Windows.Forms;

public class PlcHelper
{
    public async Task<bool> WaitForConfirmationAsync(Func<bool> confFlag, Func<int> ackCode = null, int expectedAck = 10, int timeoutSeconds = 30)
    {
        int elapsed = 0;
        while (elapsed < timeoutSeconds)
        {
            await Task.Delay(1000);
            elapsed++;

            if (!confFlag()) continue;

            if (ackCode == null || ackCode() == expectedAck)
                return true;
        }

        MessageBox.Show("Time Out");
        return false;
    }
}