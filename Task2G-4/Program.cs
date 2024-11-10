using System;

namespace Task2G_4{
    class Program{
        static void Main(string[] args){
            bool a = true;
            double b = 3.14;

            Console.WriteLine($"{(a,b)}");
            Console.WriteLine(swap_it(a,b));
        }

        static object swap_it(object a, object b){
            object a_new = b;
            object b_new = a;
            
            return (a_new, b_new); //Возврат значений по заветам Горюнова.
        }
    }
}