using DTNLightningAlert.Core.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DTNLightningAlert.Core.WorkerService
{
    public class JSONDeserializeWorkerService<T> : IJSONDeserializeWorkerService<T>
    {
        private string path;

        public JSONDeserializeWorkerService(string path)
        {
            this.path = path;
        }

        public List<T> DeserializeJsonFile()
        {
            var result = new List<T>();

            if (!string.IsNullOrEmpty(path)) {
                using (var reader = new StreamReader(path))
                {
                    string data = reader.ReadLine();

                    if (data.Contains('[') && data.Contains(']') && data.Contains(','))
                    {
                        result = DeserializeSingleLineFile(data);
                    }
                    else
                    {
                        result = DeserializeMultipleLineFile(reader, data);
                    }
                }
            }

            return result;
        }

        private List<T> DeserializeSingleLineFile(string data)
        {
            var result = new List<T>();

            if (!string.IsNullOrEmpty(data))
            {
                data = data.Trim('[', ']').Replace("},{", "}, {");

                var arrayData = data.Split(", ");

                foreach (var item in arrayData)
                {
                    result.Add(JsonConvert.DeserializeObject<T>(item));
                }
            }

            return result;
        }

        private List<T> DeserializeMultipleLineFile(StreamReader reader, string data)
        {
            var result = new List<T>();

            if (reader != null)
            {
                do
                {
                    result.Add(JsonConvert.DeserializeObject<T>(data));
                } while ((data = reader.ReadLine()) != null);
            }

            return result;
        }
    }
}
