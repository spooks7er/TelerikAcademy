

namespace BadCode
{
    using System;

    class MyClassChild
    {
        public void SomeBoolean(bool variable)
        {
            string variableAsString = variable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}