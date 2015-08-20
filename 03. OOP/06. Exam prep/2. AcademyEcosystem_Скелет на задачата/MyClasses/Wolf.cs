using System;

namespace AcademyEcosystem
{
    class Wolf : Animal, ICarnivore
    {
        public Wolf(string name, Point location)
            : base(name, location, 4)
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
            if (a != null && (this.Size >= a.Size || a.State == AnimalState.Sleeping))
            {
                return a.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}
