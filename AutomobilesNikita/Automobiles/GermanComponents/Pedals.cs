
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace GermanComponents
{

    public class Pedals : IPedals
    {
        int _pressReactionSpeed = 6;

        public Pedals()
        {
        }

        public int PressReactionSpeed
        {
            get { return _pressReactionSpeed; }
            set { _pressReactionSpeed = value; }
        }
    }
}