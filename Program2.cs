// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.IO;

public class Program2
{
    Program2()
    {}
    
    void PrimaryInteropAssemblyAttribute(object thi)
    {
        Console.WriteLine("Object: " + thi.ToString());
        Console.WriteLine("Object: " + thi);
        throw new NotImplementedException();
    }
}