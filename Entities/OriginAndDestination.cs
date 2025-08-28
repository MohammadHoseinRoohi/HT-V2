using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class OriginAndDestination : Thing
    {
        // مبدا
        public required string Origin { get; set; }
        // مقصد
        public required string Destination { get; set; }

        // چطوری ساعت های حرکت رو تعیین کنیم؟
    }
}