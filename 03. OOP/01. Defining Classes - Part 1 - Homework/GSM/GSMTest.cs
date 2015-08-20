using System;
using System.Collections.Generic;

namespace GSM
{
    public class GSMTest
    {
        public static void TestStart()
        {
            GSM gsm1 = new GSM("iPhone 4S", "Apple",
                               new Battery(BatteryType.LiPo),
                               new Display(DisplayType.LED));

            GSM gsm2 = new GSM("Desire 320", "HTC",
                               new Battery(BatteryType.LiIon),
                               new Display(DisplayType.TFT));

            GSM gsm3 = new GSM("Xperia E3 Dual", "Sony",
                               new Battery(BatteryType.LiIon),
                               new Display(DisplayType.IPS));

            GSM gsm4 = new GSM("X2 Dual SIM", "Nokia",
                               new Battery(BatteryType.LiIon),
                               new Display(DisplayType.IPS));

            GSM gsm5 = new GSM("TEST MODEL", "TEST MANUF", 536.56m, "Pesho",
                               new Battery(BatteryType.NiCd),
                               new Display(DisplayType.OLED));

            GSM gsm6 = new GSM("TEST MODEL2", "TEST MANUF2", 236.99m, "Maina");

            GSM.iPhone4s = gsm1;

            var somePhones = new List<GSM>();

            somePhones.Add(gsm1);
            somePhones.Add(gsm2);
            somePhones.Add(gsm3);
            somePhones.Add(gsm4);
            somePhones.Add(gsm5);
            somePhones.Add(gsm6);

            somePhones.Add(GSM.iPhone4s);

            foreach (var phone in somePhones)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}
