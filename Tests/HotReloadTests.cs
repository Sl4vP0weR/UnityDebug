using System;
using System.IO;
using System.Reflection;
using HotReload;

namespace Tests
{
    public static class Tests
    {
        public static void Main()
        {
            Doorstop.Entrypoint.Start();
            Console.ReadKey();

            var dir = Environment.CurrentDirectory;
            HotReloader.AddSearchDirectory(dir);
            
            var original = Assembly.GetExecutingAssembly();
            FileInfo file = new("Test.dll");
            HotReloader.HandleLoad(original, codeBase: file);

            MyMethod();
            HotReloader.Load(file);
            MyMethod();
        }
        [HotReloadable]
        public static void MyMethod()
        {
            Console.WriteLine("A");
        }
    }
}