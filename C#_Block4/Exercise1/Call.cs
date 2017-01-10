using System;
using System.Text;


namespace Exercise1
{
    public class Call
    {
        int duration = 0;
        DateTime startOfCall;
        string phoneNumber = null;

        public Call(string phoneNumber, int duration)
        {
            this.startOfCall = DateTime.Now;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
        }

        public DateTime StartOfCall
        {
            get
            {
                return this.startOfCall;
            }
        }

        public override string ToString()
        {
            StringBuilder MyCall = new StringBuilder();
            MyCall.AppendFormat("Date of call: {0}", this.startOfCall.ToString("dd.mm.yyyy")).AppendLine();
            MyCall.AppendFormat("Time of call: {0}", this.startOfCall.ToString("hh,mm tt")).AppendLine();
            MyCall.AppendFormat("Number of caller: {0}", this.PhoneNumber).AppendLine();
            MyCall.AppendFormat("Duration of call: {0}", this.Duration).AppendLine();

            return MyCall.ToString();
        }
    }
}
