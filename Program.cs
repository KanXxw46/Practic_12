using System;

namespace Practic_12
{
    class Counter
    {
        public int Value { get; set; }

        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }
    }

}
