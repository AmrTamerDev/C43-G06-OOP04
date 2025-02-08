using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Rectangle
    {
        #region Attributes
        private int width;
        private int height;

        #endregion

        #region Properties
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        #endregion


        #region Constructors
        public Rectangle()
        {
            height = 0;
            width = 0;
        }

        public Rectangle(int Width, int Height)
        {
            width = Width;
            height = Height;
        }

        public Rectangle(int Value)
        {
            width = height = Value;
        }
        #endregion

        public override string ToString()
        {
            return $"Wight = {width}\nHeight{height}";
        }
    }
}
