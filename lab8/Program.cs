using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Pixel pix1 = new Pixel();   
            Pixel pix2 = new Pixel(66,90);   
            Pixel colPix1 = new PixelWithColor();   
            Pixel colPix2 = new PixelWithColor(70,910, ConsoleColor.Green);
            Pixel colDeadPix1 = new PixelWithColor(70, 910, ConsoleColor.Green).BeatPixel();
            Pixel colDeadPix2 = new PixelWithColor(70, 910, ConsoleColor.Green).BeatPixel();

            pix1.PrintPixel();
            pix2.PrintPixel();
            colPix1.PrintPixel();
            colPix2.PrintPixel();
            colDeadPix1.PrintPixel();

            Console.WriteLine("usual pixel 1 full: {0}; only coordinates: {1}", pix1.ToString(), pix1.ToString(true));
            Console.WriteLine("colorful pixel 2 full: {0}; only coordinates: {1}", colPix1.ToString(), colPix1.ToString(true));
            Console.WriteLine("Dead colorful pixel 3 full: {0}; only coordinates: {1}", colDeadPix1.ToString(), colDeadPix1.ToString(true));

            Console.ReadKey();
        }
    }
}
