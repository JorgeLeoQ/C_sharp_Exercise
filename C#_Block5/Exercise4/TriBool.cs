using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public enum TriBoolState { Indeterminate = 0, True = 1, False = 2 }

    public class TriBool : IEquatable<TriBool>
    {
        public static TriBool True { get { return new TriBool(true); } }
        public static TriBool False { get { return new TriBool(false); } }
        public static TriBool Indeterminate { get { return new TriBool(); } }

        private readonly TriBoolState state;

        public TriBool(bool state)
        {
            this.state = state ? TriBoolState.True : TriBoolState.False;
        }
        public TriBool(TriBoolState state)
        {
            this.state = state;
        }
        public TriBool()
        { }

        public static bool operator true(TriBool value)
        {
            return value.state == TriBoolState.True;
        }
        public static bool operator false(TriBool value)
        {
            return value.state == TriBoolState.False;
        }
        public static bool operator ==(TriBool x, TriBool y)
        {
            return x.state == y.state;
        }
        public static bool operator !=(TriBool x, TriBool y)
        {
            return x.state != y.state;
        }
        public static TriBool operator |(TriBool x, TriBool y)
        {
            TriBoolState state = x.state;
            if (x.state > y.state)
                state = y.state;
            return new TriBool(state);
        }


        public static TriBool operator &(TriBool tB1, TriBool tB2)
        {
            TriBoolState state = tB1.state;
            if (tB1.state < tB2.state)
                state = tB2.state;
            return new TriBool(state);
        }

        public static TriBool operator !(TriBool tB)
        {
            if (tB.state == TriBoolState.True)
                return new TriBool(TriBoolState.False);
            else if (tB.state == TriBoolState.False)
                return new TriBool(TriBoolState.True);
            else return new TriBool(tB.state);
        }

        public override string ToString()
        {
            return state.ToString();
        }
        public override bool Equals(object obj)
        {
            return (obj != null && obj is TriBool) ? Equals((TriBool)obj) : false;
        }
        public bool Equals(TriBool value)
        {
            return value == this;
        }
        public override int GetHashCode()
        {
            return state.GetHashCode();
        }
        public static implicit operator TriBool(bool value)
        {
            return new TriBool(value);
        }
        public static explicit operator bool(TriBool value)
        {
            switch (value.state)
            {
                case TriBoolState.True: return true;
                case TriBoolState.False: return false;
                default: throw new InvalidCastException();
            }
        }
    }
}
