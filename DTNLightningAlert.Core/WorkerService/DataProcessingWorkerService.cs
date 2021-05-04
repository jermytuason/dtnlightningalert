using DTNLightningAlert.Core.Constants;
using DTNLightningAlert.Core.Interface;
using DTNLightningAlert.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTNLightningAlert.Core.WorkerService
{
    public class DataProcessingWorkerService : IDataProcessingWorkerService
    {
        private string lightningFilePath;
        private string assetFilePath;
        private List<LightningModel> lightningModelList;
        private List<AssetModel> assetModelList;

        public DataProcessingWorkerService(string lightningFilePath, string assetFilePath)
        {
            this.lightningFilePath = lightningFilePath;
            this.assetFilePath = assetFilePath;
        }

        public void ShowData()
        {
            InitializeDataFromFiles();

            var lightningAlertData = (from lightningDataItem in lightningModelList.Where(x => x.FlashType == FlashTypeConstants.CloudToGround || x.FlashType == FlashTypeConstants.CloudToClound)
                                      join assetDataItem in assetModelList
                                          on CalculationsWorkerService.CalculateQuadKey(lightningDataItem.Latitude, lightningDataItem.Longitude) equals assetDataItem.QuadKey
                                      select new
                                      {
                                          assetDataItem.AssetOwner,
                                          assetDataItem.AssetName
                                      }).Distinct().ToList();

            foreach (var item in lightningAlertData)
            {
                Console.WriteLine($"lightning alert for {item.AssetOwner}:{item.AssetName}");
            }

            Console.WriteLine("");
        }

        private void InitializeDataFromFiles()
        {
            var lightningData = new JSONDeserializeWorkerService<LightningModel>(lightningFilePath);
            var assetData = new JSONDeserializeWorkerService<AssetModel>(assetFilePath);

            lightningModelList = lightningData.DeserializeJsonFile();
            assetModelList = assetData.DeserializeJsonFile();
        }
    }
}
