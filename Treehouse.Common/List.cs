using System;

namespace Treehouse.Collections.Generic
{
    public class List<T> : System.Collections.Generic.List<T>
    {
        private static Random _random = new Random();

        public T RandomItem()
        {
            return this[_random.Next(0, Count)];
        }
    }
}