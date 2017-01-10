using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    public enum BatteryType { LithiumIon, LithiumPolymer, NickelMetalHydride, NickelCadmium, NewLithiumTechnology };

    public class Battery
    {
        public BatteryType TypeOfBattery { set; get; }
        private string model = null;
        public double IdleTime { set; get; }
        public double HoursTalk { set; get; }

        public Battery(string model, double idleTime, double hoursTalk, BatteryType typeOfBattery)
        {
            this.model = model;
            this.IdleTime = idleTime;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }
        public Battery(string model, double idleTime, double hoursTalk) : this(model, idleTime, hoursTalk, BatteryType.LithiumIon)
        { }
        public Battery(string model, double idleTime) : this(model, idleTime, 0)
        { }
        public Battery(string model) : this(model, 0)
        { }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public override string ToString()
        {
            StringBuilder MyBattery = new StringBuilder();
            MyBattery.AppendFormat("Model: {0}", this.Model).AppendLine();
            MyBattery.AppendFormat("Idle Time: {0}", this.IdleTime).AppendLine();
            MyBattery.AppendFormat("Hours talk: {0}", this.HoursTalk).AppendLine();
            MyBattery.AppendFormat("Type of Battery: {0}", this.TypeOfBattery).AppendLine();

            return MyBattery.ToString();
        }
    }
}
