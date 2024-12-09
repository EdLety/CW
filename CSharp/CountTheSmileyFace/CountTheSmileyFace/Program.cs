using System.Text.RegularExpressions;
using System.Linq;

namespace CountTheSmileyFace
{
   internal class Program
   {
      static void Main(string[] args) {
         var smile = new string[] { ":D", ":~)", ";~D", ":)" };
         Console.WriteLine(CountSmileys(smile));
         Console.ReadKey();
      }
      /// <summary>
      /// 6 kyu - Count the smiley faces! - https://www.codewars.com/kata/583203e6eb35d7980400002a/train/csharp - DONE
      /// </summary>
      /// <param name="smileys"></param>
      /// <returns></returns>
      public static int CountSmileys(string[] smileys) {
         if (smileys is null)
            return 0;

         string pattern = @"^[:;][-~]?[)D]$";
         return smileys.Count(face => Regex.IsMatch(face, pattern));
      }
   }
}
