using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace RegExExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"c:\dev\test.html");
            var separtingChars = ' ';
            var links = text.Split(separtingChars, (char)StringSplitOptions.RemoveEmptyEntries );
            
            var beginPattern = @"(href)";       // not a word a href @"([^\w*]a href)"
            var options  = RegexOptions.IgnoreCase;
            //var pattern = "(<a href='//\\.?)"; //Matches each occurance of <a href='https://
            //Replaces the pattern in link with an empty string
            //var myRegEx = Regex.Replace(link, pattern, String.Empty );
            //var myRegExMatches = Regex.Matches(link, beginPattern, options);

            //Console.WriteLine(text);
            //Regex.Matches(text, beginPattern, options);

            MatchCollection match =  Regex.Matches(text, beginPattern, options);
            //Console.WriteLine(match);
            

            foreach (var n in match)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(match.Count);
        }
    }
}
