using System;

namespace AcademyEcosystem
{
    class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point location)
            : base(name, location, 6)
        {

        }

        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }

            base.Update(timeElapsed);
        }

        public int TryEatAnimal(Animal a)
        {
            if (a != null && this.Size >= a.Size / 2)
            {
                this.Size++;
                return a.GetMeatFromKillQuantity();
            }
            return 0;
        }
    }
}
