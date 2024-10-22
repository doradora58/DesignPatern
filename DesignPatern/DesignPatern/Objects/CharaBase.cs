using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Objects
{
    public abstract class CharaBase
    {
     
        public CharaBase(int x, int y, Color color) 
        {
            X = x;
            Y = y;
            Color = color;
        }
        public int X {  get; set; }
        public int Y {  get; set; }

        public Color Color { get; }

        public abstract void Right();
        public abstract bool IsMessageTiming();
        public abstract string GetMessage();
    }
}
