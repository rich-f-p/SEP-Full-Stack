using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alphaValue;

        public Color(int red, int green, int blue, byte alphaValue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alphaValue = alphaValue;
        }

        public Color(int red,int green, int blue)
        {
            this.red=red;
            this.green=green;
            this.blue=blue;
            this.alphaValue = 255;
        }

        public int Red
        { 
            get { return red; } 
            set { red = value; }
        }
        public int Green
        {
            get { return green; }
            set { green = value; }
        }
        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }
        public int AlphaValue
        {
            get { return alphaValue; }
            set { alphaValue = value; }
        }
        public int GetGrayscale()
        {
            return (red+green+blue)/3;
        }

    }
}
