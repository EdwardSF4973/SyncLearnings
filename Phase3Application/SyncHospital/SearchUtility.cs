using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class SearchUtility<Type>
    {

        public static int BinarySearch(CustomList<Type> list, string key, string propertyName, out Type element)
        {
            element = default(Type);

            int left = 0, right = list.Count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                //Get the property value of the specified property name

                //object middleValue = GetPropertyValue(list[middle], propertyName);

                object middleValue = list[middle].GetType().GetProperty(propertyName).GetValue(list[middle], null);

                if (middleValue != null)
                {
                    int comparisonResult = middleValue.ToString().CompareTo(key);
                    //Check if the middle element matches the key
                    if (comparisonResult == 0)
                    {
                        element = list[middle];
                        return middle;
                    }
                    //Adjust search bounds
                    if (comparisonResult < 0)
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
            }
            // Element not found 
            return -1;
        }

    }
}
