using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double width, height, woodLength, glassArea;
            //string widthString, heightString;

            //widthString = Console.ReadLine();
            //width = double.Parse(widthString);

            //heightString = Console.ReadLine();
            //height = double.Parse(heightString);

            //woodLength = 2 * (width + height) * 3.25;
            //glassArea = 2 * (width * height);

            //Console.WriteLine("The length of the wood is " + woodLength + " feet");
            //Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            //int first, second, third;
            //first = 1;
            //second = 2;
            //third = second + first;
            //Console.WriteLine(third);
            //Console.ReadLine();

            //Casting

            //double d = 1.5;
            //float f = (float)d;
            //int f = (int)d;
            //int i;
            //i = (int) 1.999;
            //Console.WriteLine(i);
            //Console.ReadLine();

            //int i = 3, j = 2;
            //float fraction;
            //fraction = (float)i / (float)j;
            //Console.WriteLine("Fraction is: "+fraction);
            //Console.ReadLine();


            //int bottleCount = ((tabletCount + 99) / 100);
            //int salePrice = bottleCount * pricePerBottle;

            //string pricePerBottleString = Console.ReadLine();
            //int pricePerBottle = int.Parse(pricePerBottleString);

            //string tabletCountString = Console.ReadLine();
            //int tabletCount = int.Parse(tabletCountString);

            //int bottleCount = ((tabletCount + 99) / 100);
            //int salePrice = bottleCount * pricePerBottle;

            //Console.WriteLine("The number of bottle is " + bottleCount);
            //Console.WriteLine("The total price is " + salePrice);


            /*Glazer Calculator to calculate
             - The length of the wood in ft.
            - The area of the glass in sq ms */
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            string widthString, heightString;
            Console.Write("Give the width of the window : "); 
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n "); 
                Console.WriteLine("Using minimum");
                width = MIN_WIDTH;
            }
            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large.\n\n"); 
                Console.WriteLine("Using maximum");
                width = MAX_WIDTH;
            }
            Console.Write("Give the height of the window : "); 
            heightString = Console.ReadLine(); 
            height = double.Parse(heightString);

            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n"); 
                Console.WriteLine("Using minimum");
                height = MIN_HEIGHT;
            }
            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n"); 
                Console.WriteLine("Using maximum");
                height = MAX_HEIGHT;
            }
            woodLength = 2 * (width + height) * 3.25; glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.ReadLine();
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadLine();

        }
    }
}
