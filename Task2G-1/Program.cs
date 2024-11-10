using System;
using System.Collections;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace Program{
    class Program{
        static void Main(string[] args){
            Generic_pair pair = new Generic_pair(32, true);
            pair.return_pair();

            pair.Change_type(pair.x,"double",'x');

            pair.Change_type(pair.y,"int",'y');

            pair.Change_type(pair.x,"boolean",'x');

        }
    }
    class Generic_pair{
        public object x;
        public object y;

        public Generic_pair(object x, object y){
            this.x = x;
            this.y = y;
        }

        public void return_pair(){
            Console.WriteLine($"Пара значений: {x}, {y}\n");
        }

        public object Change_type(object argument, String data, char part){
            switch (data){
                case "int":
                    argument = Convert.ToInt32(argument); 
                    break;
                case "double":
                    argument = Convert.ToDouble(argument);
                    break;

                case "boolean":
                    argument = Convert.ToBoolean(argument);
                    break;

                }

            switch (part){
                case 'x':
                    x = argument;
                    break;
                case 'y':
                    y = argument;
                    break;
            }

            return_pair();
            return 0;
            }
            
        }
    }
