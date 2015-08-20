namespace WarMachines
{
    using WarMachines.Engine;
    using WarMachines.Machines;

    public class WarMachinesProgram
    {
        public static void Main()
        {
            //Tank a1m1 = new Tank("Abrams", 200, 250);
            //System.Console.WriteLine(a1m1.ToString());



            WarMachineEngine.Instance.Start();
        }
    }
}
