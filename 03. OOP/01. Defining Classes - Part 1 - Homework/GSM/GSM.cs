using System;
using System.Text;
using System.Collections.Generic;
namespace GSM
{
    public class GSM
    {
        private readonly decimal _callRate = CallRate.Rate;
        private const uint _secInMin = 60;

        private string model;
        private string manufacturer;
        private decimal? price = null;
        private string owner = null;
        private Battery battery = new Battery(BatteryType.None);
        private Display display = new Display(DisplayType.None);
        private List<Call> callHistory = new List<Call>();
        private TimeSpan totalCallTime = new TimeSpan();
        private decimal sumToPay = 0.0m;

        // iPhone4S
        // Problem 6. Static field -
        // ne mi stana qsno kakvo tochno se iska tuk i kakuv e smisula,
        // no raboti, puk dano da sum ucelil
        private static GSM iPhone4sField;

        public static GSM iPhone4s
        {
            get { return iPhone4sField; }
            set { iPhone4sField = value; }
        }
        // iPhone4S end


        // Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string manufacturer, string model, decimal? price, string owner)
            : this(manufacturer, model)
        {
            this.PhonePrice = price;
            this.PhoneOwner = owner;
        }

        public GSM(string manufacturer, string model, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.PhoneBattery = battery;
            this.PhoneDisplay = display;
        }

        public GSM(string manufacturer, string model, decimal? price, string owner,
                   Battery battery, Display display)
            : this(manufacturer, model, price, owner)
        {
            this.PhoneBattery = battery;
            this.PhoneDisplay = display;
        }
        //


        // // Properties
        // Model
        public string PhoneModel
        {
            get { return this.model; }
        }

        // Manufacturer
        public string PhoneManufacturer
        {
            get { return this.manufacturer; }
        }

        // Price
        public decimal? PhonePrice
        {
            get { return this.price; }
            set { this.price = value; }
        }

        // Owner
        public string PhoneOwner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Battery
        public Battery PhoneBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        // Display
        public Display PhoneDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }
        // //

        // To String
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Model - " + model);
            info.AppendLine("Manufacturer - " + manufacturer);
            info.AppendLine("Price - " + price);
            info.AppendLine("Owner - " + owner);
            info.AppendLine("Battery - " + battery.BatteryType);
            info.AppendLine("Display - " + display.DisplayType);

            return info.ToString();
        }
        //

        // Call History props
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
            sumToPay += (call.DurationInSeconds / _secInMin) * _callRate;
            totalCallTime += call.Duration;
        }

        public void DeleteCalls(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        //		public decimal CalculateTotalPrice()
        //		{
        //			decimal spentMoney = 0.0m;
        //			decimal entireDuration = 0.0m;
        //			foreach (var call in CallHistory)
        //			{
        //				entireDuration += (call.DurationInSeconds/_secInMin);
        //			}
        //			spentMoney += (entireDuration*_callRate);
        //			return spentMoney;
        //		}

        public TimeSpan TotalCallTime
        {
            get { return this.totalCallTime; }
        }

        public decimal SumToPay
        {
            get { return this.sumToPay; }
        }
        //
    }
}