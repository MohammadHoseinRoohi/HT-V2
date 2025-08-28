using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Driver : Employee
    {
        // شماره پلاک
        // public required string LicensePlateNumber { get; set; }
        // شماره گواهینامه
        public double CertificateNumber { get; set; }
    }
}