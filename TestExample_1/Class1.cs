﻿using System;

namespace TestExample_1
{
    public class Class1
    {
        public static bool Calcolo1()
        {
            double a = 1.0 / 10.0;
            double s =a + a + a + a + a + a + a + a + a + a;
            if (s == 1)
                return true;
            else
                return false;
        }
    }
}
