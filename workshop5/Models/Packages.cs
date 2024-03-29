﻿using System;
using System.Collections.Generic;

namespace workshop5.Models
{
    public partial class Packages

    {
        public Packages()
        {
            Bookings = new HashSet<Bookings>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSuppliers>();
        }

        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
        public string Images { get; set; }


        public ICollection<Bookings> Bookings { get; set; }
        public ICollection<PackagesProductsSuppliers> PackagesProductsSuppliers { get; set; }

    }
}
