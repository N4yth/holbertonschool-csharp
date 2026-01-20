using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }
        
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}