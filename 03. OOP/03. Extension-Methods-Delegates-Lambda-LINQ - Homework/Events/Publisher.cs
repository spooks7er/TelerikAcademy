using System;
using System.Linq;

namespace Events
{
    class Publisher
    {
        public delegate void CustomEventHandler(object sender, SampleEvent e);

        public event CustomEventHandler RaiseCustomEvent;

        public void RaiseSampleEvent()
        {
            Console.WriteLine("An event will be raised");
            OnRaiseCustomEvent(new SampleEvent("This is the custom event"));
        }

        public void OnRaiseCustomEvent(SampleEvent e)
        {
            //CustomEventHandler handler = RaiseCustomEvent;

            if (RaiseCustomEvent != null)
            {
                e.SampleMessage += String.Format(" at {0}", DateTime.Now);

                RaiseCustomEvent(this, e);
            }
        }
    }
}
