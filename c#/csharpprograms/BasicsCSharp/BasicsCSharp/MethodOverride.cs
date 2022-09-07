using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class RBI
    {
        public float roi = 0F;

        public virtual float rateOfInterest()
        {
            roi = 2.5F;
            return roi;
        }
    }

    internal class SBI:RBI
    {
        
        public  override float rateOfInterest()
        {
            roi = 5F;
            return roi;
        }
    }

    internal class KarnatakaBank : RBI
    {

        public float rateOfInterest()
        {
            roi = 7F;
            return roi;
        }

        public void info()
        {
            Console.WriteLine("I am Karnataka Bank");
        }
    }
    internal class MethodOverride
    {
        public static void testMethodOverride()
        {
            /**
            SBI sbi = new SBI();
            float rate = sbi.rateOfInterest();
            Console.WriteLine("SBI Rate of Interest" + rate);
            */
            RBI rbi = new SBI();
            float rate = rbi.rateOfInterest();
            Console.WriteLine("SBI Rate of Interest" + rate);

            rbi = new KarnatakaBank();
            rate = rbi.rateOfInterest();
            Console.WriteLine("Karnataka Bank Rate of Interest" + rate);
            //rbi.info();
        }

    }
}
