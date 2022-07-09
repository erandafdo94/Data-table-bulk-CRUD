using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingaTest.Models
{
    public class MonthData
    {
        public int Id { get; set; }
        public int Jan { get; set; }
        public int Feb { get; set; }
        public int March { get; set; }
        public int April { get; set; }
        public int May { get; set; }
        public int June { get; set; }
        public int July { get; set; }
        public int August { get; set; }
        public int September { get; set; }
        public int October { get; set; }
        public int November { get; set; }
        public int December { get; set; }


        public int SeriesesId { get; set; }
        public Serieses Serieses { get; set; }
    }
}