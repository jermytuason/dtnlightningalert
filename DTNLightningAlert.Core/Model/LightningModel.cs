using System;
using System.Collections.Generic;
using System.Text;

namespace DTNLightningAlert.Core.Model
{
    public class LightningModel
    {
        public int FlashType { get; set; }
        public Int64 StrikeTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int PeakAmps { get; set; }
        public string Reserved { get; set; }
        public int IcHeight { get; set; }
        public Int64 ReceivedTime { get; set; }
        public int NumberOfSensors { get; set; }
        public int Multiplicity { get; set; }
    }
}
