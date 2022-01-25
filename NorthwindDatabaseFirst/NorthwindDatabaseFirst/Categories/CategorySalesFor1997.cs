using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabaseFirst.Models
{
    public partial class CategorySalesFor1997 : NorthwindContext
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
