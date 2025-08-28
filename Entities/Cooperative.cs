using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Cooperative : Thing
    {
        // نام تعاونی
        public required string CooperativeName { get; set; }
        // کارمند
        public required Employee Employee { get; set; }
        // راننده
        public required Driver Driver { get; set; }
        // زمان شروع به کار
        public DateTime Started { get; set; }
    }
}