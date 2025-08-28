using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Manager : Employee
    {
        // نام کاربری
        public required string Username { get; set; }
        // رمز عبور
        public double Password { get; set; }
    }
}