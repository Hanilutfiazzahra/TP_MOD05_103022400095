using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MOD05_103022400095
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}
