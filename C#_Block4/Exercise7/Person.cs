using System;
using System.Net.Mail;
using System.Globalization;
using System.Text;

namespace Exercise7
{
    public class Person
    {
        public DateTime BirthDate { get; }
        public string FirstName { private set; get; }
        public string LastName { private set; get; }
        public MailAddress Email { set; get; }


        public Person(string firstName, string lastName, DateTime birthDate, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            CheckValidDate(birthDate);
            this.BirthDate = birthDate;
            CheckValidMail(email);
        }
        public Person(string firstName, string lastName, string email)
            :this(firstName, lastName, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), email)
        { }
        public Person(string firstName, string lastName, DateTime birthDate)
            :this(firstName, lastName, birthDate, "Example@unige.it")
        { }

        //that method used for cheked email
        private void CheckValidMail(string email)
        {
            try
            {
                this.Email = new MailAddress(email);
            }
            catch (FormatException fe)
            {
                throw new FormatException(fe.Message);
            }
        }

        private void CheckValidDate(DateTime birthDate)
        {
            if(birthDate.Year >= DateTime.Now.Year)
            {
                throw new BirthFutereException("Invalid Date, you are not a person of future =D.");
            }
            if(birthDate.Year < 1910) //person too old
            {
                throw new TooOldBirthException("Invalid Date, too old.");
            }
        }

        public bool Adult
        {
            get
            {
                if((DateTime.Now.Year - BirthDate.Year) >= 18 || BirthDate.Month > DateTime.Now.Month || BirthDate.Day > DateTime.Now.Day)
                {
                    return true;
                }
                return false;
            }
        }

        public bool Birthday
        {
            get
            {
                if(BirthDate.Day == DateTime.Now.Day && BirthDate.Month == DateTime.Now.Month)
                {
                    return true;
                }
                return false;
            }
        }

        public string MyZodiac
        {
            get
            {
                string zodiacSign = null;

                switch (BirthDate.Month)
                {
                    case 1:
                        if (BirthDate.Day <= 20)
                        { zodiacSign = "Your zodiac sign is Capricorn"; }
                        else
                        { zodiacSign = "Your zodiac sign is Aquarius"; }
                        break;
                    case 2:
                        if (BirthDate.Day <= 19)
                        { zodiacSign = "Your zodiac sign is Aquarius"; }
                        else
                        { zodiacSign = "Your zodiac sign is Pisces"; }
                        break;
                    case 3:
                        if (BirthDate.Day <= 20)
                        { zodiacSign = "Your zodiac sign is Pisces"; }
                        else
                        { zodiacSign = "Your zodiac sign is Aries"; }
                        break;
                    case 4:
                        if (BirthDate.Day <= 20)
                        { zodiacSign = "Your zodiac sign is Aries"; }
                        else
                        { zodiacSign = "Your zodiac sign is Taurus"; }
                        break;
                    case 5:
                        if (BirthDate.Day <= 21)
                        { zodiacSign = "Your zodiac sign is Taurus"; }
                        else
                        { zodiacSign = "Your zodiac sign is Gemini"; }
                        break;
                    case 6:
                        if (BirthDate.Day <= 22)
                        { zodiacSign = "Your zodiac sign is Gemini"; }
                        else
                        { zodiacSign = "Your zodiac sign is Cancer"; }
                        break;
                    case 7:
                        if (BirthDate.Day <= 22)
                        { zodiacSign = "Your zodiac sign is Cancer"; }
                        else
                        { zodiacSign = "Your zodiac sign is Leo"; }
                        break;
                    case 8:
                        if (BirthDate.Day <= 23)
                        { zodiacSign = "Your zodiac sign is Leo"; }
                        else
                        { zodiacSign = "Your zodiac sign is Virgo"; }
                        break;
                    case 9:
                        if (BirthDate.Day <= 23)
                        { zodiacSign = "Your zodiac sign is Virgo"; }
                        else
                        { zodiacSign = "Your zodiac sign is Libra"; }
                        break;
                    case 10:
                        if (BirthDate.Day <= 23)
                        { zodiacSign = "Your zodiac sign is Libra"; }
                        else
                        { zodiacSign = "Your zodiac sign is Scorpio"; }
                        break;
                    case 11:
                        if (BirthDate.Day <= 22)
                        { zodiacSign = "Your zodiac sign is Scorpio"; }
                        else
                        { zodiacSign = "Your zodiac sign is Sagittarius"; }
                        break;
                    case 12:
                        if (BirthDate.Day <= 21)
                        { zodiacSign = "Your zodiac sign is Sagittarius"; }
                        else
                        { zodiacSign = "Your zodiac sign is Capricorn"; }
                        break;
                    default:
                        zodiacSign = "Your zodiac sign was not found! Sorry!";
                        break;
                }

                return zodiacSign;
            }
        }

        public string MyChineseZodiacal
        {
            get
            {
                EastAsianLunisolarCalendar chineseZodiacal = new ChineseLunisolarCalendar();
                int sexagenaryYear = chineseZodiacal.GetSexagenaryYear(BirthDate);
                int terrestrialBranch = chineseZodiacal.GetTerrestrialBranch(sexagenaryYear);
                string[] years = "Rat,Ox,Tiger,Rabbit,Dragon,Snake,Horse,Goat,Monkey,Rooster,Dog,Pig".Split(',');
                return years[terrestrialBranch - 1];
            }
        }

        public string ScreenName
        {
            get
            {
                StringBuilder myInfo = new StringBuilder();
                myInfo.AppendFormat("{0} {1} born on {2} ", this.FirstName, this.LastName, this.BirthDate.Month.ToString());
                if(BirthDate.Day == 1)
                {
                    myInfo.Append("1st ");
                }
                else if(BirthDate.Day == 2)
                {
                    myInfo.Append("2nd ");
                }
                else if(BirthDate.Day == 3)
                {
                    myInfo.Append("3rd ");
                }
                else
                {
                    myInfo.AppendFormat("{0}th ", this.BirthDate.Day);
                }
                myInfo.Append(BirthDate.Year.ToString());
                return myInfo.ToString();
            }
        }
    }
}
