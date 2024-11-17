// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

namespace task2P_1
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello world!");

            Bank_account Daniel = new Bank_account("Daniel",5000);

            Daniel.print_money();
            Daniel.add_money();
            Daniel.spend_money();
        }
    }
    class Bank_account{
        public String name;
        public int current_money;

        public  Bank_account(String name, int current_money){
            this.name = name;
            this.current_money = current_money;
        }
        
        public void print_money(){
            Console.WriteLine($"Текущая сумма на счету: {current_money}");
        }
        
        public int add_money(){
            int new_money;
            Console.WriteLine("Введите сумму для пополнения: ");
            
            new_money = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            current_money += new_money;
            
            Console.WriteLine($"Вы пополнили счет на {new_money} рублей!");
            print_money();

            return current_money;
        }

        public int spend_money(){
            int new_money;
            Console.WriteLine("Введите сумму для снятия: ");
            
            new_money = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            current_money -= new_money;

            Console.WriteLine($"Вы списали со чёта {new_money} рублей!");
            print_money();

            return current_money - new_money;
        }

    }
}