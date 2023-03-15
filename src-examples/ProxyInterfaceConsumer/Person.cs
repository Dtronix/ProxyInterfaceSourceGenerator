using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProxyInterfaceConsumer
{
    public class Person
    {
        private int PrivateId { get; }
        public int Id { get; }

        public object @object { get; set; }

        public long? NullableLong { get; }

        public string Name { get; set; }

        public string? StringNullable { get; set; }

        public E E { get; set; }

        public bool TMethod<T1, T2>(int x, T1 t1, T2 t2)
            where T1 : struct
            where T2 : class, new()
        {
            return true;
        }

        public int DefaultValue(int x = 100)
        {
            return x + 1;
        }

        public string Add(string s, string @string)
        {
            return s + @string;
        }

        public string HelloWorld(string name)
        {
            return $"Hello {name} !";
        }

        public void AddWithParams(params string[] values)
        {
        }

        public void In_Out_Ref1(in int a, out int b, ref int c)
        {
            b = 1;
            c++;
        }

        public void Void()
        {
        }

        public Task Method1Async()
        {
            return Task.CompletedTask;
        }

        public Task<int> Method2Async()
        {
            return Task.FromResult(1);
        }

        public Task<string?> Method3Async()
        {
            return Task.FromResult((string?)"");
        }
    }

    public enum E
    {
        V1,
        V2
    }
}