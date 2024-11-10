using System;

namespace Task2G_2{
    class Program{
        static void Main(string[] args){
            double [] mass = {-1,0,1,2,3,4,-20,6,7,8,9,10,-11};
            double minimum = FindMin(mass);

            Console.WriteLine(minimum);

        }
        
        static T FindMin<T>(T[] massive) where T : IComparable<T>
        {
            T min = massive[0];
            
            for (int i = 0; i < massive.Length; i++){
                if (massive[i].CompareTo(min) < 0)
                {
                min = massive[i];
                }
            }
            return min;
        }
    }
}