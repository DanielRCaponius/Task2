using System;

namespace Task2P_4{
    class Program{
        static void Main(string[] args){
            Rectangle_4 square_pizza = new Rectangle_4(2,4);
            Circle Pizza = new Circle(1);

            square_pizza.Get_area();
            Pizza.Get_area();
        }
    }

    abstract class Shape(){
        public abstract double Get_area();

    }

    class Rectangle_4 : Shape {
        public double a;
        public double b;

        public Rectangle_4(double a, double b){
            this.a = a;
            this.b = b;
        }

        public override double Get_area(){
            double area = a*b;
            Console.WriteLine($"Площадь четырехугольника равна {area}");
            return area;
        }

    }

    class Circle : Shape {
        public double radius;
        public Circle(double radius){
            this.radius = radius;
        }
        public override double Get_area(){
            double area = Math.Round(Math.PI*radius*radius,5);
            Console.WriteLine($"Площадь окружности равна {area}");
            return area;
        }

    }


}