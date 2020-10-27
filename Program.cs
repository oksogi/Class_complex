
using System;
using System.Threading;

namespace Class_complex
{

    class Complex
    {
        private double _real;
        private double _imagine;

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
            get 
            {
                double mod = Math.Sqrt(_real * _real + _imagine * _imagine);
                return mod; 
            }
        }

        public double arg
        {
            get
            {
                
                double res_n = Math.Atan2(_real, _imagine);
                if ((_real < 0) && (_imagine > 0)) res_n += Math.PI;
                if ((_real < 0) && (_imagine < 0)) res_n -= Math.PI;
                if ((_real == 0) && (_imagine < 0)) res_n = - Math.PI;
                if ((_real == 0) && (_imagine > 0)) res_n = Math.PI;
                return res_n;
            }
        }
       
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
        

        public static Complex operator *(Complex a, Complex b)
        {
            double real = a.Re * b.Re - a.Im * b.Im;
            double imagine = a.Re * b.Im + a.Im * b.Re;
            return new Complex(real, imagine);
        }

        public static Complex operator *(Complex a, double b)
        {
            double real = a.Re * b;
            double imagine = a.Im * b;
            return new Complex(real, imagine);
        }

        public static Complex operator *(double a, Complex b)
        {
            double real = a * b.Re;
            double imagine = a * b.Im;
            return new Complex(real, imagine);
        }
        

        public static Complex operator /(Complex a, Complex b)
        {
            double real = (a.Re * b.Re + b.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im);
            double imagine = (a.Im * b.Re - b.Im * b.Re) / (b.Re * b.Re + b.Im * b.Im);
            return new Complex(real, imagine);
        }

        public static Complex operator /(Complex a, double b)
        {
            return new Complex(a.Re / b, a.Im / b);
        }

        public static Complex operator /(double a, Complex b)
        {
            
            double real = (a * b.Re)/ (b.Re * b.Re + b.Im * b.Im);
            double imagine = (-a * b.Im)/( b.Re * b.Re + b.Im * b.Im);
            return new Complex(real, imagine);
        }

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


        public void WriteComplex(Complex a)
        {
           // Console.WriteLine(a.Re);
            Console.WriteLine( a.Re + "  + " + $"{a.Im}*i");

        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(0);
            Complex b = new Complex(0);
            Console.Write("Введите целую часть a: ");
            a.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть a: ");
            a.Im = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть b: ");
            b.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть b: ");
            b.Im = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введенные комплексные числа: ");
            a.WriteComplex(a);
            b.WriteComplex(b);
            double f = a.arg;
            Console.WriteLine(" Аргумент числа а: " + f);
            double mod = b.module;
            Console.WriteLine(" Модуль числа b: " + mod);
            Complex res = a * b * (a + b) + (a - b) / a;
            res.WriteComplex(res);
        }
    }
}



