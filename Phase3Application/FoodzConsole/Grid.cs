using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public static class Grid<Type>
    {
        public static void PrintTables(CustomList<Type> dataList)
        {
            PropertyInfo[] proper = typeof(Type).GetProperties();

            foreach (PropertyInfo prop in proper)
            {
                System.Console.Write($"| {prop.Name,-18} ");
            }
            Console.Write(" |\n");

            //printing table body
            foreach (var info in dataList)
            {
                foreach (PropertyInfo p in proper)
                {
                    if (p.CanRead)
                    {
                        if (p.GetValue(info).GetType().Equals(new DateTime().GetType()))
                        {
                            Console.Write($"| {((DateTime)p.GetValue(info)).ToString("dd/MM/yyyy"),-19}");
                        }
                        else
                        {
                            Console.Write($"| {p.GetValue(info),-20}");
                        }
                    }
                }
                Console.Write(" |\n");
            }
        }
    }
}