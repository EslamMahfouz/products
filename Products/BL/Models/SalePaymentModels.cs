﻿using System;
using System.ComponentModel;

namespace Products.BL.Models
{

    public class SalePaymentModel
    {
        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("المدفوع")]
        public double Paid { get; set; }

        [DisplayName("نوع السداد")]
        public string Type { get; set; }

    }
}
