using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SingaTest.Models
{
    public class MonthData
    {
        
        public int Id { get; set; }
        [Required]
        public int Jan { get; set; }
        [Required]
        public int Feb { get; set; }
        [Required]
        public int March { get; set; }
        [Required]
        public int April { get; set; }
        [Required]
        public int May { get; set; }
        [Required]
        public int June { get; set; }
        [Required]
        public int July { get; set; }
        [Required]
        public int August { get; set; }
        [Required]
        public int September { get; set; }
        [Required]
        public int October { get; set; }
        [Required]
        public int November { get; set; }
        [Required]
        public int December { get; set; }


        public int SeriesesId { get; set; }
        public Serieses Serieses { get; set; }
    }
}