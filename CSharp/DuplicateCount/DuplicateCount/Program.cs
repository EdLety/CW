using System;

namespace DuplicateCount
{
   class Program
   {
      static void Main(string[] args) {
         Console.WriteLine(DuplicateCounts("Indivisibility"));
         Console.ReadKey();
        }
      public static int DuplicateCounts(string str) {
         // old solution
         /*string text = str.ToLower();
         var duplicates = new HashSet<char>();
         var duplicateCounts = new Dictionary<char, int>();

         foreach (char c in text) {
            int charCount = 0;
            bool isDuplicate = duplicateCounts.TryGetValue(c, out charCount);
            duplicateCounts[c] = ++charCount;
            if (isDuplicate)
               duplicates.Add(c);
         }
         return duplicates.Count;*/
         // new solution
         return str.ToLower()
                   .GroupBy(c => c)
                   .Where(g => g.Count() > 1)
                   .Count();
      }
   }
}