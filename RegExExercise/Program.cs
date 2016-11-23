using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = "dfsdkjfskjdfnskjdfsdf<a href='https://www.google.com'/>dmflkmklsmddsc <a href='http://www.yahoo.com'/>";
            var beginPattern = "<a href=";
            var endPattern = "/>";
            var options  = RegexOptions.IgnoreCase;
            //var pattern = "(<a href='//\\.?)"; //Matches each occurance of <a href='https://
            //Replaces the pattern in link with an empty string
            //var myRegEx = Regex.Replace(link, pattern, String.Empty );
            var myRegExMatches = Regex.Matches(link, beginPattern, options);

            foreach (var n in myRegExMatches)
            {
                Console.WriteLine(n);
            }
            //Console.WriteLine(myRegExMatches.Count);
        }
    }
}
