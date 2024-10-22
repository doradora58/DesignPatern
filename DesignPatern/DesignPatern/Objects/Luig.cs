using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Objects
{
    public sealed class Luig : CharaBase
    {
        private int _count = 0;
        public Luig() : base(10, 50, Color.Green)
        {

        }

        public override string GetMessage()
        {
            return "I am Luig";
        }

        public override bool IsMessageTiming()
        {
            _count++;
            if (_count >= 5)
            {
                _count = 0;
                return true;
            }
            return false;
        }

        public override void Right()
        {
            base.X += 20;
        }
    }
}
