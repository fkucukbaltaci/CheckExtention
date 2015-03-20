using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckExtention.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("something@example.com".Is().Email());
            //System.Console.WriteLine("somethdsfsdf.com".Is().Email());
            //System.Console.WriteLine("somethdsfsdf.com".Is().Not().Email());
            //System.Console.WriteLine("somethdsfsdf.com".Is().Not().Not().Email());
            //System.Console.WriteLine(false & true);

            //System.Console.WriteLine("--------------------------------");

            //int a = 1;
            //System.Console.WriteLine(a.Is().Zero());
            //System.Console.WriteLine(a.Is().Not().Zero());

            //WriteLine("b");
            //decimal b = 1;
            //WriteLine(b.Is().Zero());
            //WriteLine(b.Is().Negative());
            //WriteLine(b.Is().Positive());

            //WriteLine("------------------------------");
            //WriteLine("double c = 0.1");
            //double c = 0.1;
            //WriteLine(c.Is().Negative());

            //WriteLine("------------------------------");
            //WriteLine(typeof(float));
            //float f = 0.1F;
            //WriteLine(f.Is().Negative());

            double a = 10.1;
            WriteLine(a % 2);
            
            WriteLine("-------------");
            WriteLine((2.1).Is().Equal(1));

            WriteLine("------ String -------");
            string sValue = "a";
            WriteLine("string.IsNullOrEmpty : " + string.IsNullOrEmpty(sValue));
            WriteLine("string.IsNullOrWhiteSpace : " + string.IsNullOrWhiteSpace(sValue));
            WriteLine("Is.Assigned :" + Is.Assigned(sValue));
            WriteLine("Convert.IsDBNull :" + Convert.IsDBNull(sValue));

            object objObject = new object();
            WriteLine("objObject.Is().Null() : " + objObject.Is().Null());

            object objObject2 = "100000000";
            WriteLine(Convert.ToInt64(objObject2));

            object objObject3 = "11,1,1";
            double retDouble;

            bool Result = Double.TryParse(Convert.ToString(objObject3), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retDouble);
            WriteLine(retDouble);

            Stop();
        }

        static void WriteLine(object Text){
            System.Console.WriteLine(Text);
        }
        static void Stop()
        {
            System.Console.ReadLine();
        }
    }
}
