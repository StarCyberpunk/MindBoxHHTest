namespace mindboxHH
{
    public abstract class Shape
    {
        public string Name { get; private set; }

        public Shape(string Name)
        {
            this.Name = Name;
        }

        public abstract double Calc();
    }
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(string Name, double Radius) : base(Name)
        {
            this.Radius = Radius;
        }

        public override double Calc()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }

    public class Triangle : Shape
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(string Name, double a, double b, double c) : base(Name)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Сторона даолжна быть больше 0");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException("Сумма сторон должна быть больше 3 ей");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public override double Calc()
        {
            double p = (a + b + c) / 2;
            double res = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            return res;
        }

        public bool IsRectangular()
        {
            bool check = (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                         || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                         || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return check;
        }
    }
}