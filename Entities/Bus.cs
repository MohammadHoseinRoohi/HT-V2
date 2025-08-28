using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Bus : Thing
    {
        // نام مالک
        public required string OwnerFirstname { get; set; }
        // نام خانوادگی مالک
        public required string OwnerLastname { get; set; }
        // کد ملی مالک
        public required string NationalCodeOwner { get; set; }
        // یک کد ۱۷ رقمی منحصر به فرد شامل حروف و اعداد انگلیسی است و همانند اثر انگشت، هویت و اطلاعات اختصاصی آن وسیله نقلیه را مشخص می‌کند   ،  Vehicle Identification Number
        public required string VIN { get; set; }
        // پلاک خودرو
        public required string LicensePlateNumber { get; set; }
        // مدل
        public double Model { get; set; }
        // ظرفیت
        public double Capacity { get; set; }
        // رنگ
        public required string Color { get; set; }
    }
}