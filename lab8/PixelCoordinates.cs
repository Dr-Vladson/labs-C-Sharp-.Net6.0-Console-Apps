using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    abstract class PixelCoordinates
    {
        protected int x;
        protected int y;

        public int GetX
        {
            get => x;
        }
        public int GetY
        {
            get => y;
        }

        public override string ToString()
        {
            return "{\"x\":" + x + ",\"y\":" + y + "}";
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;

            PixelCoordinates p = (PixelCoordinates)obj;
            return (x == p.x) && (y == p.y);
        }

        public abstract PixelCoordinates ChangeX(int x);
        public abstract PixelCoordinates ChangeY(int y);
    }
}
