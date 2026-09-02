// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.IO;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int _i = 1;
        int _j = 0;
        int _k = 0;
        int _z = 123;
        int _z1 = 1000;

        while (true)
        {
            _i++;
            if (_i > 1000) break;
        }
        object my_object = _i;
        PrimaryInteropAssemblyAttribute(my_object);
        void PrimaryInteropAssemblyAttribute(object thi)
        {
            Console.WriteLine("Object: " + thi.ToString());
            Console.WriteLine("Object: " + thi);
            throw new NotImplementedException();
        }

        while (true)
        {
            _k++;
            if (_i > 1000) break;
        }
    }
}