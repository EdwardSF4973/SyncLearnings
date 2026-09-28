using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class Grid<Type>
    {
        public static void PrintTables(CustomList<Type> dataList)
        {
            PropertyInfo[] proper = typeof(Type).GetProperties();

            foreach (PropertyInfo prop in proper)
            {
                System.Console.Write($"| {prop.Name,-10} ");
            }
            Console.Write(" |\n");

            //printing table body
            foreach (Type info in dataList)
            {
                foreach (PropertyInfo p in proper)
                {
                    if (p.CanRead)
                    {
                        if (p.PropertyType == typeof(DateTime))
                        {
                            var value = ((DateTime)p.GetValue(info)).ToString("dd/MM/yyyy", null);
                            System.Console.Write($" {value,-14} | ");
                        }
                        else
                        {
                            Console.Write($"| {p.GetValue(info),-10}");
                        }
                    }
                }
                Console.Write(" |\n");
            }
        }
    }
}