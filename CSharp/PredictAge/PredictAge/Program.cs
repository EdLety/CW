using System;

namespace PredictAge
{
   class Program
   {
      static void Main(string[] args) {
         Console.WriteLine(PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
         Console.ReadKey();
      }
      public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8) {
         var sum = 0;
         var x = new int[] { age1, age2, age3, age4, age5, age6, age7, age8 };
         foreach (var item in x) {
            sum += Convert.ToInt32(item * item);
         }
         var fin = Convert.ToInt32(Math.Ceiling(Math.Sqrt(sum) / 2)) - 1;
         return fin;
      }
   }
}