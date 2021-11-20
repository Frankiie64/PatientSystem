using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public sealed class GlobalRepositoty
    {
        public static GlobalRepositoty Instance { get; } = new GlobalRepositoty();

        public int TyperUser = new int();
        private GlobalRepositoty()
        { }
    }
}
