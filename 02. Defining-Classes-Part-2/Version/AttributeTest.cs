namespace Version
{
    using System;
    using System.Reflection;

    class AttributeTest
    {
        static void Main(string[] args)
        {
            var attr = typeof(AttributeTest).GetCustomAttributes<AttributeVersion>();

            foreach (var attribute in attr)
            {
                Console.WriteLine("{0}: {1}     Version: {2}",
                    attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}
