using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabaseFirst
{
    public partial class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
