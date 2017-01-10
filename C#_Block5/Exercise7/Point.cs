using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public enum typeCodinate { POLAR, CARTESIAN}

    public class Point
    {
        private double ascissa;
        private double ordinate;
        private double argument;
        private double module;

        public Point(double firstValue, double secondValue)
            :this(firstValue, secondValue, typeCodinate.CARTESIAN)
        { }
        public Point(double firstValue, double secondValue, typeCodinate type)
        {
            if (type == typeCodinate.CARTESIAN)
            {
                this.ascissa = firstValue;
                this.ordinate = secondValue;
            }
            else if (type == typeCodinate.POLAR)
            {
                this.argument = firstValue;
                this.module = secondValue;
            }
        }

        public double X
        {
            get { return this.ascissa; }
            set { this.ascissa = value; }
        }
        public double Y
        {
            get { return this.ordinate; }
            set { this.ordinate = value; }
        }

        public double Argument
        {
            get { return this.argument; }
            set { this.argument = value; }
        }
        public double Module
        {
            get { return this.module; }
            set { this.module = value; }
        }

        public void ConvertPolar(double x, double y)
        {
            this.argument = Math.Atan2(y, x);
            this.module = Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 1 / 2);
        }

        public void ConvertCartesian(double module, double argument)
        {
            this.ascissa = module * Math.Cos(argument);
            this.ascissa = module * Math.Cos(argument);
        }

        public static Point Add(Point p1, Point p2)
        {
            return new Point(p1.ascissa + p2.ascissa, p1.ordinate + p2.ordinate, typeCodinate.CARTESIAN);
        }

        public static Point Subtract(Point p1, Point p2)
        {
            return new Point(p1.ascissa - p2.ascissa, p1.ordinate - p2.ordinate, typeCodinate.CARTESIAN);
        }
        public void Offset(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public void Offset(Point p)
        {
            Offset(p.X, p.Y);
        }

        public static bool ZeroPoint(Point point)
        {
            bool type = false;
            double distance = Math.Abs(point.X + point.Y);
            if (distance <= 0.0001)
                type = true;
            return type;
        }

        public static int Compare(Point p1, Point p2)
        {
            int indexArray = -1;

            if (p1.X + p1.Y > p2.X + p2.Y)
                indexArray = 1; // add a position
            else if (p1.X + p1.Y == p2.X + p2.Y)
                indexArray = 0; // if equal no move

            return indexArray;// return -1 if less
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.ascissa, this.ordinate);
        }
    }
}
