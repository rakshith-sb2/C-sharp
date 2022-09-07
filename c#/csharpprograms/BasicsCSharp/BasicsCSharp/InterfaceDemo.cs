using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal interface IUniversalRemote
    {
        public void SwitchOn();
        public void SwitchOff();
        public string changeChannel(string channel);
        // public String changeChannel(String channel)
        // public int changeVolume(int volume)
        // TCLTV has to implement IUniversalRemote
    }

    internal class SonyTV : IUniversalRemote
    {
        bool tvStatus = false;
        string currentChannel = "";

        public string changeChannel(string channel)
         {
            currentChannel=channel;
            //Console.WriteLine("SonyTV: Channel is changed to "+channel);
            return currentChannel;

        }

        public void SwitchOff()
        {
            // throw new NotImplementedException();
            if (tvStatus)
            {
                tvStatus = false;
                Console.WriteLine("SonyTV is Switched OFF");
            }
            else
            {
                Console.WriteLine("SonyTV is already Switched OFF");
            }
        }

        public void SwitchOn()
        {
            //throw new NotImplementedException();
            if (!tvStatus)
            {
                tvStatus = true;
                Console.WriteLine("SonyTV is Switched ON");
            }
            else
            {
                Console.WriteLine("SonyTV is already Switched ON");
            }
        }
    }
    internal class InterfaceDemo
    {
        public static void interfaceDemo()
        {

            IUniversalRemote iURemote = new SonyTV();
            iURemote.SwitchOn();
            iURemote.SwitchOff();
            string currentChannel = iURemote.changeChannel("Star Sports 1");
            Console.WriteLine("SonyTV: Channel is changed to "+ currentChannel);
        }

    }
}
