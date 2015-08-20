using System;

namespace GSM
{
    class AStartProgram
    {
        public static void Main(string[] args)
        {
            //GSMTest.TestStart(); // for testing GSM class, creates different phones and stores their info

            CallTest.TestStart(); // tests the Call class and the CallHistory of GSM class, it simulates a call and stores info about the call
        }
    }
}