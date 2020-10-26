
using System;

namespace Class_complex
{

    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public struct Complex
    {
       /// <summary>
        /// Бросаемое исключение при неудачном парсинге строки
        /// </summary>
       
            private double _real;
            private double _imagine;
            

            #region
            public Complex(double real, double imagine)
            {
                _real = real;
                _imagine = imagine;
                
            }

            public Complex(double real)
            {
                _real = real;
                _imagine = 0;
            }
            public  Complex ( Complex x)
            {
                _real = x.Re;
                _imagine = x.Im;
            }

            #endregion
            public double Re
            {
                get { return _real; }
                set { _real = value; }
            }

            public double Im
            {
                get { return _imagine; }
                set { _imagine = value; }
            }


           




        }
    }
}


