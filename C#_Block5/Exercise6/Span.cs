using System;
using System.Collections;

namespace Exercise6
{

    public class Spam
    {
        private readonly int from;
        private readonly int to;

        public Spam(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int From
        {
            get { return from; }
        }

        public int To
        {
            get { return to; }
        }

        public int Length
        {
            get { return Math.Abs(to - from) + 1; }
        }

        public static Spam operator +(Spam i, int j)
        {
            return new Spam(i.From + j, i.To + j);
        }

        public static Spam operator +(int j, Spam i)
        {
            return new Spam(i.From + j, i.To + j);
        }

        public static Spam operator >>(Spam i, int j)
        {
            return new Spam(i.From, i.To + j);
        }

        public static Spam operator <<(Spam i, int j)
        {
            return new Spam(i.From + j, i.To);
        }

        public static Spam operator *(Spam i, int j)
        {
            return new Spam(i.From * j, i.To * j);
        }

        public static Spam operator *(int j, Spam i)
        {
            return new Spam(i.From * j, i.To * j);
        }

        public static Spam operator -(Spam i, int j)
        {
            return new Spam(i.From - j, i.To - j);
        }

        public static Spam operator !(Spam i)
        {
            return new Spam(i.To, i.From);
        }

        public static explicit operator int[] (Spam i)
        {
            int[] res = new int[i.Length];
            for (int j = 0; j < i.Length; j++)
                res[j] = i[j];
            return res;
        }

        public int this[int i]
        {
            get
            {
                if (from <= to)
                {
                    if (i >= 0 && i <= Math.Abs(from - to))
                    {
                        return from + i;
                    }
                    else
                    {
                        throw new Exception("Out of index");
                    }
                }
                else if (from > to)
                {
                    if (i >= 0 && i <= Math.Abs(from - to))
                    {
                        return from - 1;
                    }
                    else
                    {
                        throw new Exception("Out of index");
                    }
                }
                else
                {
                    throw new Exception("\"from\" is more greatest than \"to\"");
                }
            }
        }

        private class IntervalEnumerator : IEnumerator
        {

            private readonly Spam interval;
            private int index;

            public IntervalEnumerator(Spam i)
            {
                this.interval = i;
                index = -1;  
            }

            public Object Current
            {
                get
                {
                    return (interval.From < interval.To) ? interval.From + index : interval.From - index;
                }
            }

            public bool MoveNext()
            {
                if (index < Math.Abs(interval.To - interval.From))
                {
                    index++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new IntervalEnumerator(this);
        }
    }
}