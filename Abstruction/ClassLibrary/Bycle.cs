using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Bycle:Vehicle
    {
        public override void Drive(double drivekm)
        {
            Millage += drivekm;
            Console.WriteLine($"Millage: {Millage}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
