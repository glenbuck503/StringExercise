using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Glen";
            string age = "33";
            string location = "Portland,OR";

            location = location.ToUpper();

            Console.WriteLine(age + name + location);

            Console.WriteLine("Hello my name is " + name + " .I am " + age + " and I am from " + location);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Today was cold");
            sb.Append(" It was 33 degrees outside and I didnt wear a jacket.");
            sb.Append(" Tomorrow I will wear one.");
              
            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
