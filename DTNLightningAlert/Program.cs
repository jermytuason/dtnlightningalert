using System;
using DTNLightningAlert.Core.Common;
using DTNLightningAlert.Core.WorkerService;

namespace DTNLightningAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    EnterFilePath(out string lightningDataFilePath, out string assetDataFilePath);

                    var dataProcessingWorkerService = new DataProcessingWorkerService(lightningDataFilePath, assetDataFilePath);

                    dataProcessingWorkerService.ShowData();
                } while (IsRunAgain());
            }
            catch (Exception ex)
            {
                LoggingWorkerService.RecordErrorLogs(ex.Message);
            }
        }

        private static void EnterFilePath(out string lightningDataFilePath, out string assetDataFilePath)
        {
            Console.WriteLine("Please enter file path for Lightning Data: ");
            lightningDataFilePath = Console.ReadLine().ToString();
            lightningDataFilePath = FileValidation.FileChecker(lightningDataFilePath);
            Console.WriteLine("");

            Console.WriteLine("Please enter file path for Asset Data: ");
            assetDataFilePath = Console.ReadLine().ToString();
            assetDataFilePath = FileValidation.FileChecker(assetDataFilePath);
            Console.WriteLine("");
        }

        private static bool IsRunAgain()
        {
            var result = false;

            Console.WriteLine("Do you want to try again? Press Y to Continue, or any key to Quit: ");
            var quitProgram = Console.ReadLine().ToString().ToUpper();

            if (quitProgram == "Y")
            {
                result = true;
            }

            Console.WriteLine("");
            return result;

        }
    }
}
