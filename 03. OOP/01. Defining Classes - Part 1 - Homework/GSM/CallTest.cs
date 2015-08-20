using System;
using System.Text;
namespace GSM
{
    public class CallTest
    {
        public static void TestStart()
        {
            GSM newPhone = new GSM("TEST PHONE", "SOME BRAND", 236.99m, "Maina",
                                   new Battery(BatteryType.LiIon),
                                   new Display(DisplayType.IPS));

            Console.WriteLine("<<<<Testing some calls>>>>\n");
            Dialer dialer = new Dialer();

            while (!Console.KeyAvailable)
            {
                Console.WriteLine("\nEnter a phone number to call:");

                string input = Console.ReadLine();

                dialer.Dial(input);

                newPhone.AddCalls(new Call(input, dialer.CallStart, dialer.CallEnd));

                Console.WriteLine("Press SPACE for new call, \nor press ESCAPE to view calls summary.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Spacebar)
                {
                    continue;
                }
            }

            //			Call call1 = new Call("+3590000000",
            //			                      new DateTime(2015, 6, 1, 08, 56, 32),
            //			                      new DateTime(2015, 6, 1, 09, 35, 18));
            //
            //			Call call2 = new Call("+3591111111",
            //			                      new DateTime(2015, 6, 1, 12, 41, 25),
            //			                      new DateTime(2015, 6, 1, 12, 45, 45));
            //
            //			Call call3 = new Call("+3592222222",
            //			                      new DateTime(2015, 6, 1, 15, 56, 47),
            //			                      new DateTime(2015, 6, 1, 16, 23, 12));
            //
            //			Call call4 = new Call("+3593333333",
            //			                      new DateTime(2015, 6, 1, 18, 56, 16),
            //			                      new DateTime(2015, 6, 1, 19, 57, 17));
            //
            //			Call call5 = new Call("+3594444444",
            //			                      new DateTime(2015, 6, 1, 20, 56, 33),
            //			                      new DateTime(2015, 6, 1, 21, 25, 22));
            //
            //
            //
            //			newPhone.AddCalls(call1);
            //			newPhone.AddCalls(call2);
            //			newPhone.AddCalls(call3);
            //			newPhone.AddCalls(call4);

            //GetCallsInfo(newPhone);


            // total call duration and total price of calls is additive,
            // meaning it doesn't change if you remove calls from call history
            //Console.WriteLine("Total time of calls {0}",newPhone.TotalCallTime);
            //Console.WriteLine("Sum to pay ${0:F2}",newPhone.SumToPay);


            //Console.WriteLine("\nDELETING CALL 1\nAND ADDING CALL 5\n");

            //			newPhone.DeleteCalls(call1);
            //			newPhone.AddCalls(call5);
            GetCallsInfo(newPhone);
            Console.WriteLine("Total duration of calls {0}", newPhone.TotalCallTime);
            Console.WriteLine("Sum to pay ${0:F2}", newPhone.SumToPay);
        }

        private static void GetCallsInfo(GSM phone)
        {
            Console.WriteLine();
            foreach (var call in phone.CallHistory)
            {
                StringBuilder output = new StringBuilder();

                output.AppendLine("Call to Number - " + call.PhoneNumber);
                output.AppendLine("Call Duration - " + call.Duration);
                output.AppendLine("Call Duration in seconds - " + call.DurationInSeconds);
                Console.WriteLine(output);
            }
        }
    }
}
