using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Enums;

namespace Practice4.Entities
{
    public class Employee : Thing
    {
        // نام 
        public required string Firstname { get; set; }
        // نام خانوادگی
        public required string Lastname { get; set; }
        // نام پدر
        public required string Fathername { get; set; }
        // شماره تماس
        public double PhoneNumber { get; set; }
        // کد ملی
        public double NationalCode { get; set; }
        // تاریخ تولد
        public DateTime DateBirth { get; set; }
        // زمان شروع به کار
        public DateTime Started { get; set; }
        // پایان قرارداد
        public DateTime EndContract { get; set; }
        // وضعیت قرارداد ، اگر ترو بود یعنی قرارداد در جریان است ، اگر قرارداد فالس بود یعنی قرارداد اتمام یافته
        public bool ContractStatus { get; set; }
        // مدرک تحصیلی
        public Degree? Degree { get; set; }
        // کد پستی
        public double ZipCode { get; set; }

        // چگونه بگوییم پایان قرارداد = زمان شروع کار + 1سال؟ باید با کد نویسی این کار را انجام دهیم؟

        // چگونه با پایان قرارداد وضعیت قرارداد را فالس کنیم؟

        // چگونه از بک به فرانت اعلام کنیم که قرارداد اقای مثلا روحی تمام شده است یا درحال اتمام است؟

        // آیا اصلا کار بالا درست است؟
    }
}