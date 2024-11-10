using System;

namespace Task2I_4{
    class Program{
        static void Main(string[] args){
            Printer XP = new Printer();
            Invalid_Printer Canon = new Invalid_Printer();

            XP.print();
            XP.scan();

            Canon.print();
        }
    }

    interface IPrinter{
        void print();
        void scan();
    }

    interface IDevice{
        void print();
    }

    class Printer : IPrinter{
        public void print(){
            Console.WriteLine("Новый принтер печатает!");
        }

        public void scan(){
            Console.WriteLine("Новый принтер сканирует!");
        }
    }

    class Invalid_Printer: IDevice{
        public void print(){
            Console.WriteLine("Старый принтер печатает...");
        }
    }
}