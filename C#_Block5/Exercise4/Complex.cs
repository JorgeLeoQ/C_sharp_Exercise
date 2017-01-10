using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Complex
    {
        private float partReal = 0;
        private float partImm = 0;

        public Complex(float partReal, float partImm)
        {
            this.partReal = partReal;
            this.partImm = partImm;
        }

        public float PartReal
        {
            set
            {
                this.partReal = value;
            }
            get
            {
                return this.partReal;
            }
        }

        public float PartImm
        {
            set
            {
                this.partImm = value;
            }
            get
            {
                return this.partImm;
            }
        }

        public static Complex operator +(Complex op1, Complex op2)
        {
            return new Complex(op1.partReal + op2.partReal, op1.partImm + op2.partImm);
        }

        public static Complex operator -(Complex op1, Complex op2)
        {
            return new Complex(op1.partReal - op2.partReal, op1.partImm - op2.partImm);
        }

        public static Complex operator *(Complex op1, Complex op2)
        {
            float real = ((op1.partReal * op2.partReal) - (op1.partImm * op2.partImm));
            float imaginary = ((op1.partReal * op2.PartImm) + (op1.PartImm * op2.PartReal));
            return new Complex(real, imaginary);
        }

        public static Complex operator *(Complex operation, float number)
        {
            return new Complex(operation.partReal * number, operation.PartImm * number);
        }

        public static Complex operator ~(Complex operation) //coniugate compplex
        {
            return new Complex(operation.partReal, (-1) * (operation.partImm));
        }

        public static Complex operator /(Complex op1, Complex op2)
        {
            float module = Module(op2);
            if(module != 0)
            {
                float real = (op1.partReal * op2.partReal + op1.partImm * op2.partImm) / module;
                float imaginary = (op1.partImm * op2.partReal - op1.partReal * op2.partImm) / module;
                return new Complex(real, imaginary);
            }
            else
            {
                throw new Exception("Exception divide by zero.");
            }
           
        }

        private static float Module(Complex op1)
        {
            return (float)(Math.Sqrt((op1.partReal * op1.partReal) + (op1.partImm * op1.partImm)));
        }

        public static Complex operator /(Complex operation, float number)
        {
            if (number != 0)
            {
                return new Complex(operation.partReal / number, operation.partImm / number);
            }
            else
            {
                throw new Exception("Exception division by zero");
            }
        }
        public override string ToString()
        {
            if (PartReal == 0) //only part imaginary
            {
                return (String.Format("j{0}", partImm));
            }
            else if (partImm == 0) //only part real
            {
                return (String.Format("{0}", partReal));
            }
            else
            {
                return (String.Format("{0} + j{1}", partReal, partImm));
            }
        }

    }
}
