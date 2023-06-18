
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Pixel : PixelCoordinates
    {
        protected bool isPixelDead = false;
        public Pixel(int x, int y)
        {
            if (x >= 0) this.x = x;
            else this.x = 0;

            if (y >= 0) this.y = y;
            else this.y = 0;
        }

        public Pixel()
        {
            x = 0;
            y = 0;
        }

        public bool GetIsPixelDead
        {
            get => isPixelDead;
        }

        public override Pixel ChangeX(int x)
        {
            if (x >= 0) return new Pixel(x, y);

            return new Pixel(0, this.y);
        }
        public override Pixel ChangeY(int y)
        {
            if (y >= 0) return new Pixel(x, y);

            return new Pixel(this.x, 0);
        }

        public override string ToString()
        {
            return "{\"x\":" + x + ",\"y\":" + y + ",\"isPixelDead\":" + isPixelDead + "}";
        }

        public string ToString(bool onlyCoordinates)
        {
            if (onlyCoordinates) return base.ToString();

            return this.ToString();
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;
           
            Pixel p = (Pixel)obj;
            return base.Equals((PixelCoordinates)p) && (isPixelDead == p.isPixelDead);
            
        }

        public bool Equals(object? obj,bool onlyCoordinates)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;

            if (onlyCoordinates) return base.Equals((PixelCoordinates)obj);

            return this.Equals(obj);
        }

        public virtual Pixel BeatPixel()
        {
            var newPixel = new Pixel(x, y);
            newPixel.isPixelDead = true;

            return newPixel;
        }

        public virtual void PrintPixel()
        {
            Console.WriteLine("\n      *\n");
        }
    }
}
