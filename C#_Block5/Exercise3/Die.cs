using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public delegate void Notifier();

    public class Die
    {
        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int maxNumberOfEyes = 6;

        public event Notifier twoSixesInARow = delegate { };
        public event Notifier fullHouse = delegate { };

        //create a list of all history dies
        private List<int> historyDies;

        public Die()
        {
            historyDies = new List<int>();
            Toss();
        }

        public void Toss()
        {
            number = NewToss();
            historyDies.Add(number);
            if (historyDies.Count >= 2 && historyDies[historyDies.Count - 1] == 6 && historyDies[historyDies.Count - 2] == 6)
            {
                twoSixesInARow();
            }
                twoSixesInARow();
            if (IsFullHouse())
            {
                fullHouse();
            }
        }

        private int NewToss()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }

        public int CompareTo(object die)
        {
            Die myDeal = (Die)die;
            int compElem = myDeal.number;
            return number.CompareTo(compElem);
        }

        private bool IsFullHouse()
        {
            bool resultCheck = false;

            if(historyDies.Count >= 5)
            {
                int dieOne = 0;
                int dieTwo = 0;
                int counterOne = 0;
                int counterTwo = 0;

                for (int i = 5; i >= 1; i--)
                {
                    if(dieOne == 0)
                    {
                        dieOne = historyDies[historyDies.Count - i];
                        counterOne = 1;
                    }
                    else if(dieTwo == 0 && dieOne != historyDies[historyDies.Count - i])
                    {
                        dieTwo = historyDies[historyDies.Count - i];
                        counterTwo = 1;
                    }
                    else if(dieOne == historyDies[historyDies.Count - i])
                    {
                        counterOne++;
                    }
                    else if(dieTwo == historyDies[historyDies.Count - i])
                    {
                        counterTwo++;
                    }
                    else
                    {
                        return resultCheck;
                    }
                }
                resultCheck = (counterOne == 2 && counterTwo == 3) || (counterOne == 3 && counterTwo == 2);
                return resultCheck;
            }
            else
            {
                return resultCheck;
            }
        }
    }
}
