using System;
using System.Reflection;

/// <summary>
/// Obj class.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect</param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
