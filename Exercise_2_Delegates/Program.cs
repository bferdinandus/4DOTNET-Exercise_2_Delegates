using System;

namespace Exercise_2_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            WillemKlein wk = new WillemKlein();
            SimonVdMeer sm = new SimonVdMeer();

            wk.RekenUit(sm.Add, 1, 2);
            wk.RekenUit(sm.Subtract, 39, 50);

        }
    }
}
