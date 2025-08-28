using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Terminal : Thing
    {
        public required Cooperative Cooperative { get; set; }
    }
}