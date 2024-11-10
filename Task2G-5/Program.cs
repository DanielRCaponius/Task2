using System;
using System.Runtime.InteropServices.ObjectiveC;

namespace Task2G_5{
    class Program{
        static void Main(string[] args){
            ListStorage A = new ListStorage();
            A.Add(3);
            A.Add(true);
            A.Add("./'[1/1+x^2]dx = tan^-1(x)+C");
            A.Add(0x5f3759df);

            A.write_list();

            A.Get(2);
        }
    }

    interface IStorage{
        void Add(){}
        void Get(){}
    }

    class ListStorage : IStorage{
        
        List<object> list = new List<object>();
        
        public void Add(object new_obj){
            list.Add(new_obj);
        }

        public void write_list(){
            foreach(object a in list){
                Console.WriteLine(a);
            }
        }

        public void Get(int index){
            Console.WriteLine(list[index]);
        }
    }
}