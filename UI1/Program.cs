using System;
using UI1.Configuration;
using API;

namespace UI1
{
    public static class Program
    {
        public static void Main()
        {
            var configurationFile = new ConfigurationFile();

            Console.WriteLine(configurationFile.UI1String);
            Console.WriteLine(configurationFile.UI1Int);
            Console.WriteLine(configurationFile.UI1Uri);

            var widget = new Widget(configurationFile);
            widget.DoSomething();

            Console.ReadLine();
        }
    }
}
