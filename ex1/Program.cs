using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte quantity = byte.Parse(Console.ReadLine());
            byte red = 0;
            byte orange = 0;
            byte blue = 0;
            byte green = 0;
            byte max = 0;
            string color1 = null;
            for (int i = 0; i < quantity; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        red++;
                        break;
                    case "orange":
                        orange++;
                        break;
                    case "blue":
                        blue++; 
                        break;
                    case "green":
                        green++;
                        break;
                }
            }
            
            if(red > orange && red > blue && red > green)
            {
                max = red;
                color1 = "red";
            }
            else if (orange > red && orange > blue && orange > green )
            {
                max = orange;
                color1 = "orange";
            }
            else if(blue > red && blue > green && blue > orange)
            {
                max = blue;
                color1 = "blue";

            }
            else if(green > red && green > orange && green > blue)
            {
                max = green;
                color1 = "green";
            }
            Console.WriteLine("Red eggs:{0}", red);
            Console.WriteLine("Orange eggs:{0}", orange);
            Console.WriteLine("Blue eggs:{0}", blue);
            Console.WriteLine("Green eggs:{0}", green);
            Console.WriteLine("Max eggs:{0} ->{1}",max,color1);


        }
    }
}
