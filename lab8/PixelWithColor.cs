using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class PixelWithColor : Pixel
    {
        protected ConsoleColor pixColor;
        public PixelWithColor(int x, int y, ConsoleColor pixColor) : base(x, y)
        {
            this.pixColor = pixColor;
        }
        public PixelWithColor() : base()
        {
            this.pixColor = ConsoleColor.Red;
        }

        public ConsoleColor GetPixColor
        {
            get => pixColor;
        }

        public PixelWithColor ChangePixColor (ConsoleColor pixColor)
        {
            return new PixelWithColor(x, y, pixColor);
        }
        public override PixelWithColor ChangeX(int x)
        {
            if (x >= 0) return new PixelWithColor(x, y, pixColor);

            return new PixelWithColor(0, y, pixColor);
        }
        public override PixelWithColor ChangeY(int y)
        {
            if (y >= 0) return new PixelWithColor(x, y, pixColor);

            return new PixelWithColor(x, 0, pixColor);
        }

        public override string ToString()
        {
            return "{\"x\":" + x + ",\"y\":" + y + ",\"isPixelDead\":" + isPixelDead + ",\"pixColor\":" + pixColor + "}";
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;
            
            PixelWithColor p = (PixelWithColor)obj;
            return base.Equals((Pixel)p) && (pixColor == p.pixColor);
        }
        public override PixelWithColor BeatPixel()
        {
            var newPixel = new PixelWithColor(x, y, pixColor);
            newPixel.isPixelDead = true;
            newPixel.pixColor =  ConsoleColor.Gray;

            return newPixel;
        }
        public override void PrintPixel()
        {
            Console.ForegroundColor = pixColor;
            Console.WriteLine("\n      *\n");
            Console.ResetColor();
        }
    }
}
