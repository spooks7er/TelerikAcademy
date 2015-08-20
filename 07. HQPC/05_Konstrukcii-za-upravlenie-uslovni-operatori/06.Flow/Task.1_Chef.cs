using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_Vars_Consts_Data_Expressions_Hw
{
    public class Chef
    {
        private Potato GetPotato()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private void Peel(Vegetable veg)
        {
            //...
        }

        private void Cut(Vegetable veg)
        {
            //...
        }



        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}