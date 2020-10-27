
using System;
using System.Threading;

namespace Class_complex
{

    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public struct Complex
    {
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
        public Complex(Complex x)
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
        
        public double module
        {
            get { return Math.Sqrt(_real * _real + _imagine * _imagine); }
        }
         
        public double arg
        {
            get
            {
                double res_n = Math.Atan2(_real, _imagine);
                if (res_n < 0) res_n += Math.PI;
                return res_n;
            }
        }
        #region 
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }

        public static Complex operator +(Complex a, double b)
        {
            return new Complex(a.Re + b, a.Im);
        }
        public static Complex operator +(double a, Complex b)
        {
            return new Complex(a + b.Re, b.Im);
        }

        #endregion


        #region Перегруженные операторы вычитания
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }

        public static Complex operator -(Complex a, double b)
        {
            return new Complex(a.Re - b, a.Im);
        }

        public static Complex operator -(double a, Complex b)
        {
            return new Complex(a - b.Re, -b.Im);
        }
        #endregion


        #region Перегруженные операторы умножения
        public static Complex operator *(Complex a, Complex b)
        {
            double real = a.Re * b.Re - a.Im * b.Im;
            double imagine = a.Re * b.Im + a.Im * b.Im;
            return new Complex(real, imagine);
        }

        public static Complex operator *(Complex a, double b)
        {
            double real = a.Re * b ;
            double imagine = a.Im * b;
            return new Complex(real, imagine);
        }

        public static Complex operator *(double a, Complex b)
        {
            double real = a * b.Re;
            double imagine = a * b.Im;
            return new Complex(real, imagine);
        }
        #endregion


        #region Перегруженные операторы деления
        public static Complex operator /(Complex a, Complex b)
        {
            double D = b.Re * b.Re + b.Im * b.Im;
            double real =( a.Re * b.Re + b.Im * b.Im)/ (b.Re * b.Re + b.Im * b.Im);
            double imagine = (a.Im * b.Re - b.Im * b.Re) / (b.Re * b.Re + b.Im * b.Im);
            return new Complex(real, imagine);
        }

        public static Complex operator /(Complex a, double b)
        {
            return new Complex(a.Re/b, a.Im /b);
        }

        public static Complex operator /(double a, Complex b)
        {
            double D = b.Re * b.Re + b.Im * b.Im;
            double real = a * b.Re;
            double imagine = - a * b.Im;
            return new Complex(real, imagine);
        }
        #endregion
        public static bool operator ==(Complex a, Complex b)
        {
            return a.Re == b.Re && a.Im == b.Im;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return a.Re != b.Re || a.Im != b.Im;
        }

        public override bool Equals(object obj)
        {
            return this == (Complex)obj;
        }

        public override int GetHashCode()
        {
            return _real.GetHashCode() + _imagine.GetHashCode();
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Complex a = new Complex();
            Complex b = new Complex(1, 2);
            Console.WriteLine(b);
complex res = (a*b) - (c * d) + (a.mod()*a.mod() + i*d.mod()*d.mod()) + c*(b.mod()*b.mod() + i);
        }
    }
}



