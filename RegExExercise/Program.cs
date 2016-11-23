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
            var link = "dfsdkjfskjdfnskjdfsdf<a href='https://www.google.com'/>dmflkmklsmddsc";
            var pattern = "(<a href='https://\\.?)"; //Matches each occurance of <a href='https://
            //Replaces the pattern in link with an empty string
            var myRegEx = Regex.Replace(link, pattern, String.Empty );

            Console.WriteLine(myRegEx);
        }
    }
}
