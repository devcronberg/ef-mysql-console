using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MySql_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySqlContext c = new MySqlContext())
            {
                var r = c.Links.Take(100).OrderByDescending(i => i.CreateDate).ToList();
                foreach (var item in r)
                {
                    Console.WriteLine(item.Title);
                }
            }

        }
    }
}
