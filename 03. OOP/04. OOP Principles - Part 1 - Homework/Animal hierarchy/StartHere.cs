using System;
using System.Linq;

namespace AnimalHierarchy
{
    class StartHere
    {
        public static void Main(string[] args)
        {
            Dog[] dogs = {
                            new Dog(1, "Ardy", "Male", "Chihuahua"),
                            new Dog(5, "Rex", "Male", "German Shephard"),
                            new Dog(3, "Pongo", "Male", "Dalmatian"),
                            new Dog(1, "Perdita", "Female", "Dalmatian"),
                            new Dog(1, "Lassie", "Female", "Collie")
                         };

            Cat[] cats = {
                            new Tomcat(5, "Top Cat", "Stray"),
                            new Cat(2, "Tom", "Male", "Domestic short-haired cat"),
                            new Cat(4, "Garfield", "Male", "Exotic Shorthair"),
                            new Kitten(3, "Arlene", "Pink Precious"),
                            new Cat(1, "Lassie", "Female", "Collie")
                         };

            Frog[] frogs = {
                            new Frog(999, "Hypnotoad", "Male", "Alien"),
                            new Frog(8, "Kermit", "Male", "Green Frog"),
                         };

            var avgDogAge = dogs
                .Select(d => d.Age)
                .Average();

            var avgCatAge = cats
                .Select(c => c.Age)
                .Average();

            var avgFrogAge = frogs
                .Select(f => f.Age)
                .Average();

            Console.WriteLine("Average dog age is {0}\nAverage cat age is {1}\nAverage frog age is {2}"
                , avgDogAge, avgCatAge, avgFrogAge);
        }
    }
}