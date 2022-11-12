﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ExpenseDetail
    {
        public int ExpID { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }
}