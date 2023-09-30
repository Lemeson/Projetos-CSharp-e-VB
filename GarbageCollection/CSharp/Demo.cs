using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTestCSharp
{
    class Demo
    {
        public static long Instances;

        public Demo()
        {
            Instances++;
        }

        ~Demo()
        {
            Instances--;
        }
    }
}
