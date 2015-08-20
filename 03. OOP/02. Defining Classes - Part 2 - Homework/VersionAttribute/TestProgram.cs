using System;

namespace VersionAttribute
{
    [Version("v. 5.11")]
    class TestProgram
    {
        public static void Main(string[] args)
        {
            Type type = typeof(TestProgram);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}