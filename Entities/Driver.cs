using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Driver : Employee
    {
        // شماره گواهینامه
        public double CertificateNumber { get; set; }
        // اتوبوس
        public Bus Bus { get; set; }
        // سوء پیشینه
        public bool BadHistory { get; set; }
        // مبدا و مقصد مشخص شده
        public required OriginAndDestination OriginAndDestination { get; set; }
        

        // اتوبوس برای دولت است با برای تعاونی؟

    }
}