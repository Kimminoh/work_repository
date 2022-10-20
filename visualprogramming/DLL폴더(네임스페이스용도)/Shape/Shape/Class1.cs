using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle
    {
        //public int height;
        //public int width;
        public int height { get; set; }
        public int width { get; set; }
        override public string ToString()
        {
            return string.Format("Width: {0}, Height: {1}", width, height);
        }
    }
}

