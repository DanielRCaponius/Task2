using System;

namespace Task2D_5{
    class Program{
        static void Main(string[] args){
            Logger A = new Logger();
            A.Go();
        }
    }
    abstract class ILogger{
        void Go(){
        }
    }

    class Logger : ILogger{
        public void Go(){
            Console.WriteLine("Логгер идёт...");
        }
    }
}