using System;
namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public int Real { get; }

        public int Imaginary { get; }

        public Complex(int realPart, int imaginaryPart)
        {
            Real = realPart;
            Imaginary = imaginaryPart;
        }
        
        public double Modulus
        {
            get => Math.Sqrt(Real*Real + Imaginary*Imaginary);
        }

        public double Phase
        {
            get
            {
                if (Real == 0)
                {
                    if (Imaginary > 0)
                    {
                        return Math.PI / 2;
                    }
                    else if (Imaginary < 0)
                    {
                        return -Math.PI / 2;
                    }
                    else return 0;
                }
                return Math.Atan(Imaginary)/Real;
            }
            
        }

        public Complex Complement() => new Complex(Real, -Imaginary);

        public Complex Plus(Complex toSum) => new Complex(Real + toSum.Real, Imaginary + toSum.Imaginary);

        public Complex Minus(Complex toSub) => new Complex(Real-toSub.Real, Imaginary - toSub.Imaginary);

        public override string ToString()
        {
            char sign = Imaginary >= 0 ? '+' : '-'; 
            return $"{Real}{sign}i{Math.Abs(Imaginary)}";
        }

        public override bool Equals(object obj)
        {
            Complex arg = (Complex)obj;
            return Real == arg.Real && Imaginary == arg.Imaginary;
        }

    }
}