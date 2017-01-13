using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Properties
{
    public class Rectangle
    {
        private float height;
        private float width;

        public Rectangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public float Area
        {
            get
            {
                return height * width;
            }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }
}
