namespace CategorizeNewMember
{
   internal class Program
   {
      static void Main(string[] args) {
         var a = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
         OpenOrSenior(a);
         Console.WriteLine();
         Console.ReadKey();
      }
      /// <summary>
      /// 7 kyu - Categorize New Member - https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/train/csharp - DONE
      /// </summary>
      /// <param name="data"></param>
      /// <returns></returns>
      public static IEnumerable<string> OpenOrSenior(int[][] data) {
         // old solution (before ref)
         /*List<string> list = new List<string> ();
         IEnumerable<string> strings = new string[] { };
         for (int i = 0; i < data.Length; i++) {
            var x2 = data[i];
            if (data[i][0] > 54 && data[i][1] > 7) {
               list.Add("Senior");
            }
            else
               list.Add("Open");

         }
         strings = list;
         return strings;*/
         // new solution (after ref)
         return data.Select(member => member[0] > 54 && member[1] > 7 ? "Senior" : "Open");
      }
   }
}
