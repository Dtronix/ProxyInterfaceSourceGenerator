using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProxyInterfaceConsumer
{
    public class Program
    {
        private static JsonSerializerOptions JsonSerializerOptions = new ()
        {
            WriteIndented = true
        };

        public static void Main()
        {
            IPerson p = new PersonProxy(new Person());
            p.Name = "test";
            p.HelloWorld("stef");
            // p.Address = ap;

            Console.WriteLine("DefaultValue " + p.DefaultValue());
            Console.WriteLine("DefaultValue " + p.DefaultValue(42));

            Console.WriteLine(JsonSerializer.Serialize(p, JsonSerializerOptions));
        }
    }
    
}