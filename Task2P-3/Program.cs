using System;

namespace Task2P_3{
    class Program{
        static void Main (string[] args){
            Dog Argem = new Dog("Аргем",10,4);
            Cat Maxwell = new Cat("Максвелл", 6, 4);
            
            Animal[] animals = {Argem, Maxwell};
            foreach (Animal animal in animals){
                animal.make_Sound();
            }
        }
    
    class Animal{
        
        public String name;
        public int age;
        public int paws;

        public Animal(String name, int age, int paws){
            this.name = name;
            this.age = age;
            this.paws = paws;
        }

        public virtual void make_Sound(){
            Console.WriteLine("Животное делает звук!");
        }

    }

    class Dog : Animal{
        public Dog(String name, int age, int paws) : base(name, age , paws){
            
        }
        public override void make_Sound()
        {
            Console.WriteLine("Собака делает 'ГАВ!'");
        }
        }
    class Cat : Animal{
        public Cat(String name, int age, int paws) : base(name, age , paws){
            
        }
        public override void make_Sound()
        {
            Console.WriteLine("Кошка делает 'МЯУ!'");
        }
        }
    }
}