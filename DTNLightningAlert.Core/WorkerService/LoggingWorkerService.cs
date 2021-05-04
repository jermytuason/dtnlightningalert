using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DTNLightningAlert.Core.WorkerService
{
    public static class LoggingWorkerService
    {
        public static void RecordErrorLogs(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                using (var writer = File.AppendText($"ErrorLogs_{DateTime.Now.ToString("MM-dd-yyyy")}"))
                {
                    writer.WriteLine(message);
                }
            }
        }
    }
}
