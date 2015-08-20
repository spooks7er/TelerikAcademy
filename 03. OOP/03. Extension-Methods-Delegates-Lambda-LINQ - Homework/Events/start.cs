using System;

namespace Events
{
    class Start
    {
        static void Main(string[] args)
        {
            Publisher eventPublisher = new Publisher();
            new Subscriber("Sub1", eventPublisher); //create subscribers for the event
            new Subscriber("Sub2", eventPublisher);

            eventPublisher.RaiseSampleEvent(); //sample event is raised by the publisher and handled by the subscribers
        }
    }
}
