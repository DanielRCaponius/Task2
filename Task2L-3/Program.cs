using System;

namespace Task2L_3{
    class Program{
        static void Main(string[] args){
            Bird Eagle = new Bird("Альфред","Орёл");
            Penguin Wazowsky = new Penguin("Вазовский","Императорский пингвин");

            Eagle.Fly();
            Wazowsky.Fly();
        }
    }

    class Bird {
        public String name;
        public String specie;

        public virtual void Fly(){
            Console.WriteLine("Птица полетела!...");
        }

        public Bird(String name, String specie){
            this.name = name;
            this.specie = specie;
        }
    }
    class Penguin : Bird{
        public Penguin(String name, String specie) : base (name, specie){

        }

        public override void Fly(){
            Console.WriteLine("Упс... Пингвин не может летать. :/");
        }
       
    }
}