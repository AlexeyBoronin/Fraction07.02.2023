using static System.Console;
Fraction frac=new Fraction(1,2);
Fraction frac1=new Fraction(25,225);
Fraction frac2=Fraction.Sum(frac, frac1);
frac2.Print();
frac.Print();
frac1.Print();
frac2 = Fraction.Pow(frac1);
frac2.Print();
frac2 = Fraction.GetReducedFraction(frac1);
frac2.Print();
class Fraction
{
    int numerator;
    int denominator;

    public Fraction(int numerator=0, int denominator=1)
    {
        this.numerator = numerator;
        if (denominator == 0)
            WriteLine("Знаменатель не может быть равен нулю");//throw new FractionException("");
        else
            this.denominator = denominator;
    }
    public static Fraction Sum(Fraction f,Fraction f1)
    {
        Fraction buf = new Fraction();
        buf.numerator=f.numerator*f1.denominator+f1.numerator*f.denominator;
        buf.denominator = f1.denominator*f.denominator;
        return buf;
    }
    public static Fraction Sum(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator + chislo * f.denominator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Sum(int chislo,Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator + chislo * f.denominator;
        buf.denominator = f.denominator;
        return buf;
    }

    public static Fraction Sub(Fraction f,Fraction f1)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * f1.denominator - f1.numerator * f.denominator;
        buf.denominator = f1.denominator * f.denominator;
        return buf;
    }
    public static Fraction Sub(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator - chislo * f.denominator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Sub(int chislo, Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = chislo * f.denominator-f.numerator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Mult(Fraction f,Fraction f1)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * f1.numerator;
        buf.denominator = f1.denominator * f.denominator;
        return buf;
    }
    public static Fraction Mult(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * chislo;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Mult(int chislo,Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * chislo;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Div(Fraction f, Fraction f1)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * f1.denominator;
        buf.denominator = f1.numerator * f.denominator;
        return buf;
    }
    public static Fraction Div(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator;
        buf.denominator = f.denominator * chislo;
        return buf;
    }
    public static Fraction Div(int chislo, Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = chislo * f.denominator;
        buf.denominator = f.numerator;
        return buf;
    }
    public static Fraction GetReducedFraction(Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator;
        buf.denominator = f.denominator;
        if (f.numerator >= f.denominator)
        {
            if (f.numerator % f.denominator == 0)
            {
                buf.numerator /= buf.denominator;
                buf.denominator = 1;
            }
        }
        else
        {
            int temp = f.numerator;
            while (temp > 0)
            {
                if (f.denominator % temp == 0 && f.numerator % temp == 0)
                {
                    buf.numerator = f.numerator / temp;
                    buf.denominator = f.denominator / temp;
                    break;
                }
                temp--;
            }
        }

        return buf;
    }
    public static Fraction Pow(Fraction f)
    {
        Fraction buf = new Fraction();
        buf = Fraction.Mult(f, f);
        return buf;
    }
    /*public static Fraction SQRT(Fraction f)//подумать
    {
        Fraction buf = new Fraction();
        return buf;
    }*/


    public void Print()
    {
        WriteLine($"{numerator}/{denominator}");
    }

}
class FractionExcepction:Exception
{
    public int Value { get; }
    public FractionExcepction(string message,int val) : base(message) { Value = val; }
}

