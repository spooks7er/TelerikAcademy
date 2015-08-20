using System;

namespace GSM
{
    public class Battery
    {
        private BatteryType battType;

        public Battery(BatteryType battType)
        {
            this.battType = battType;
        }

        public BatteryType BatteryType
        {
            get { return battType; }
        }
    }
}
