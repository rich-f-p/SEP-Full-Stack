using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Ball
    {
        private int size;
        private Color color;
        private int trackCount;

        public Ball(int size, Color color, int trackCount)
        {
            this.size = size;
            this.color = color;
            this.trackCount = trackCount;
        }
        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }
        public int Size 
        { 
            get { return size; } 
            set { size = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Pop()
        {
            this.size = 0;
        }
        public void Throw()
        {
            if (this.size != 0)
            {
                this.trackCount++;
            }
        }

        public int TrackCount() 
        { 
            return this.trackCount; 
        }

    }
}
