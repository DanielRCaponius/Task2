using System;

namespace Task2S_1{
    class Program{
        static void Main(string[] args){
            Employee IvanSpacebiker = new Employee("Космический байкер Иван","Байкер",52,50000);
            Salary_counter Scounter = new Salary_counter();

            Scounter.Raise(IvanSpacebiker);
            Scounter.Penatly(IvanSpacebiker);
        }
    }
    class Employee{
        public String name;
        public String role;
        public int age;
        public double salary;

        public Employee(String name, String role, int age, double salary){
            this.name = name;
            this.role = role;
            this.age = age;
            this.salary = salary;
        }
    }

    class Salary_counter{
        public double Raise(Employee obj){
            Console.WriteLine($"Введите сумму, на которую вы хотите повысить зарплату сотрудника {obj.name}: ");
            
            double addition = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            obj.salary += addition;

            Console.WriteLine($"Зарплата сотрудника повышена на {addition}!");
            Console.WriteLine($"Итоговая зарплата: {obj.salary}");

            return obj.salary;
        }

        public double Penatly(Employee obj){
            Console.WriteLine("Введите сумму, на которую вы хотите снизить зарплату: ");
            double minus = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            obj.salary -= minus;

            Console.WriteLine($"Зарплата сотрудника понижена на {minus}!");
            Console.WriteLine($"Итоговая зарплата: {obj.salary}");

            return obj.salary;
        }

    }
}