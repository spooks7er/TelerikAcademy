using System;

namespace GSM
{
    public class Display
    {
        private DisplayType dispType;

        public Display(DisplayType dispType)
        {
            this.dispType = dispType;
        }

        public DisplayType DisplayType
        {
            get { return dispType; }
        }
    }
}
