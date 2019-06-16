using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Dto
{
    public class MyData
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DataProperties Properties { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }

        public SystemProperties SystemProperties { get; set; }
    }
}
