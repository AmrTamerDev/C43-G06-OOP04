using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class ComplexNumber
    {
        #region Attributes
        private int real;
        private int imaginary;
        #endregion

        #region Properties
        public int Real
        {
            get { return real; }
            set { real = value; }

        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }

        public static ComplexNumber operator + (ComplexNumber Num1C, ComplexNumber Num2C)
        {
            return new ComplexNumber()
            {
                real = (Num1C?.real ?? 0) + (Num2C?.real ?? 0),
                imaginary = (Num1C?.imaginary ?? 0) + (Num2C?.Imaginary ?? 0)
            };
        }

        public static ComplexNumber operator -(ComplexNumber Num1C, ComplexNumber Num2C)
        {
            return new ComplexNumber()
            {
                real = (Num1C?.real ?? 0) - (Num2C?.real ?? 0),
                imaginary = (Num1C?.imaginary ?? 0) - (Num2C?.Imaginary ?? 0)
            };
        }
        #endregion


    }
}
