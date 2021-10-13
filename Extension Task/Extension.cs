using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Task
{
    public static class Extension
    {
        public static int Task(this string name1,string name2)
        {
            string[] arr = name1.Split(" ");
            int count = 0;
            foreach (var item in arr)
            {
                if (item==name2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
