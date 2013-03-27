using System;
using UI2.Configuration;
using API;

namespace UI2
{
    public static class Program
    {
        public static void Main()
        {
            var configurationFile = new ConfigurationFile();

            Console.WriteLine(configurationFile.UI2String);
            Console.WriteLine(configurationFile.UI2Int);
            Console.WriteLine(configurationFile.UI2Uri);

            var widget = new Widget(configurationFile);
            widget.DoSomething();

            Console.ReadLine();
        }
    }
}
