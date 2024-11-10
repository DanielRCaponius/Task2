using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Task2G_3{
    class Program{
        static void Main(string[] args){
            T Anna = new T("Anna");
            T Rian = new T("Rian");
            T Julia = new T("Julia");
            T Daniel = new T("Daniel");

            Repository list = new Repository();

            list.add(Anna);
            list.add(Rian);
            list.add(Julia);
            list.add(Daniel);

            list.print_list();

            list.Get_element(0);
            list.Get_element(1);

        }
    }

    class T{
        public String name;
        public T(String name){
            this.name = name;
        }
    }
    
    class Repository{
        List<T> massive = new List<T>();
        
        public void print_list(){
            
            foreach (T character in massive){
                Console.WriteLine(character.name);
            }
        }
        public void Get_element(int index){
            Console.WriteLine($"Имя элемента с индексом {index}: {massive[index].name}");
        }

        public void add(T new_element){
            massive.Add(new_element);
        }

    }

}