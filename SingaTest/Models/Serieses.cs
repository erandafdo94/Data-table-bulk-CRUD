using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingaTest.Models
{
    public class Serieses
    {
        public int SeriesesId { get; set; }
        public string Ecs { get; set; }
        public string Bcat { get; set; }
        public string Series { get; set; }

        public ICollection<MonthData> MonthData { get; set; }
    }
}