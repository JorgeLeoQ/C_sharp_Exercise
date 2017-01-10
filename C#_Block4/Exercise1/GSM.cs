using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class GSM
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        private decimal price = 0;
        public string Owner { get; set; }
        private Battery myBattery = null;
        private Display myDisplay = null;
        static public GSM samsungGalaxyS7;
        private List<Call> myCallHistory = new List<Call>();

        static GSM()
        {
            samsungGalaxyS7 = new GSM("Galaxy S7", "Samsung", 650M, "Leo", "3000 mA", 62, 22, 5.1, 16000000, BatteryType.LithiumIon);
        }

        //proprietis
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid price!!");
                }
            }
        }
        public List<Call> MyCallHistory
        {
            get
            {
                return this.myCallHistory;
            }
            set
            {
                this.myCallHistory = value;
            }
        }

        //costrutors
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        { }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel)
            : this(model, manufacturer, price, owner, batteryModel, 0)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, 0)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime,
            double batteryTalkTime)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, 0)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime,
            double batteryTalkTime, double displaySize)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, displaySize, 0)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime,
            double batteryTalkTime, double displaySize, uint displayColors)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, displaySize, displayColors, BatteryType.LithiumIon)
        { }
        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime,
            double batteryTalkTime, double displaySize, uint displayColors, BatteryType batteryType)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.myBattery = new Battery(batteryModel, batteryIdleTime, batteryTalkTime, batteryType);
            this.myDisplay = new Display(displaySize, displayColors);
        }

        public override string ToString()
        {
            StringBuilder myGSM = new StringBuilder();
            myGSM.AppendFormat("Model:  { 0, 10}", this.Model).AppendLine();
            myGSM.AppendFormat("Manufacturer: { 0, 10}", this.Manufacturer).AppendLine();
            if (this.Price != 0)
            {
                myGSM.AppendFormat("Price: { 0, 10}", this.Price).AppendLine();
            }
            if (this.Owner != null)
            {
                myGSM.AppendFormat("Owner: { 0, 10}", this.Owner).AppendLine();
            }
            if (this.myBattery != null)
            {
                myGSM.AppendFormat("Battery: { 0, 10}", this.myBattery).AppendLine();
            }
            if (this.myDisplay != null)
            {
                myGSM.AppendFormat("Display: { 0, 10}", this.myDisplay).AppendLine();
            }
            return myGSM.ToString();
        }

        public void AddNewCall(string phoneNumber, int duration)
        {
            Call newCall = new Call(phoneNumber, duration);
            this.MyCallHistory.Add(newCall);
        }

        public void DeleteCalls(int duration)
        {
            this.MyCallHistory.RemoveAll(theCall => theCall.Duration == duration);
        }

        public void DeleteCalls(string phoneNumber)
        {
            this.MyCallHistory.RemoveAll(theCall => theCall.PhoneNumber == phoneNumber);
        }

        public void DeleteCalls(DateTime startOfCall)
        {
            this.MyCallHistory.RemoveAll(theCall => theCall.StartOfCall == startOfCall);
        }

        public void DeleteAllCall()
        {
            this.MyCallHistory.Clear();
        }

        public decimal TotalAmouthCall(decimal pricePerMinute)
        {
            decimal total = 0.0m;

            foreach (var items in this.MyCallHistory)
            {
                total += items.Duration * pricePerMinute;
            }

            return total;
        }

        public string AllCalls()
        {
            if (this.MyCallHistory.Count > 0)
            {
                StringBuilder ArchiveOfCall = new StringBuilder();
                ArchiveOfCall.Append("--------------------------------------All calls--------------------------------------").AppendLine();
                foreach (var items in MyCallHistory)
                {
                    ArchiveOfCall.Append("\n");
                    ArchiveOfCall.Append(items).AppendLine();

                }

                return ArchiveOfCall.ToString();
            }
            else
            {
                return "The list of the call is empty.";
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
