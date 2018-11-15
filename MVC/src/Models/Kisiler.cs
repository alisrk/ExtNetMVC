using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ext.Net.MVC.Examples.Models
{
    public class Kisiler
    {
        public string id { get; set; }
        public string adi { get; set; }

        public static IEnumerable getData()
        {
            List<Kisiler> b = new List<Kisiler>();
            for (int i = 0; i < 5; i++)
            {
                Kisiler a = new Kisiler { id = ""+i, adi = "ali"+i};
                b.Add(a);
            }
            return b;
        }
    }
}