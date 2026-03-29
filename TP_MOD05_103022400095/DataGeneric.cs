using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MOD05_103022400095
{
    internal class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
