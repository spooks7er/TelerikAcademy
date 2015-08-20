using Cosmetics.Engine;
namespace Cosmetics
{
    public class CosmeticsProgram
    {
        public static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            CosmeticsEngine.Instance.Start();
        }
    }
}
