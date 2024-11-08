// See https://aka.ms/new-console-template for more information
using System;

namespace Task2P_2{
    class Program{
        static void Main (string[] Args){
            Car Lada = new Car("Какая-то лада","Черная",70,"А чёрт его знает");
            Bycicle D20 = new Bycicle("Дворовый велик", "Красный", 20, "Спортивный");
        }
    class Vehicle{
        public  String name;
        public String color;
        public int speed;

        public Vehicle(String name, String color, int speed){
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        void go(){
            Console.WriteLine("Транспорт едет...");
        }

    }
    class Car : Vehicle{
        public int wheels = 4;
        public string model;
        public Car(String name, String color, int speed, String model) : base(name, color, speed) {
            this.model = model;
        }
    }

    class Bycicle: Vehicle{
        public int wheels = 2;
        public string type;
        public Bycicle(String name, String color, int speed, String type) : base(name, color, speed) {
            this.type = type;
            }
        }
    }
}