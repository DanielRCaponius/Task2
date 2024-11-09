using System;

namespace Task2O_2{
    class Program{
        static void Main(string[] args){
            double price = 5000;

            Calculate_discount calc = new Calculate_discount();
            Percentage_Discount  pdisc = new Percentage_Discount();
            Fixed_Discount fdisc = new Fixed_Discount();

            calc.Calculate(price);
            
            pdisc.Calculate(price);
            pdisc.Calculate_by_percent(price,50);

            fdisc.Calculate(price);
            fdisc.Calculate_by_fixed(price,1000);

        }
    }

    class Calculate_discount{
        public double Calculate(double price){
            price -= 100;
            Console.WriteLine($"Цена со скидкой 100 рублей: {price}");
            return price;
        }
    }

    class Percentage_Discount : Calculate_discount{
        public double Calculate_by_percent(double price, double discount){
            price = price*(1-discount/100);
            Console.WriteLine($"Цена со скидкой {discount}%: {price}");

            return price;
        }
    }

    class Fixed_Discount : Calculate_discount{
        public double Calculate_by_fixed(double price, double f_discount){
            
            price -= f_discount;
            Console.WriteLine($"Цена со скидкой в {f_discount} рублей: {price}");
            
            return price;
        }
    }

}