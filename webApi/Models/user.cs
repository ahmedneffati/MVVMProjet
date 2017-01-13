using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class user
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Lat { get; set; }
        public float lon { get; set; }
    }
}