using Materialy.DBModel;
using System;

namespace Materialy.Forms
{
    internal class SupplyM
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Unit { get; set; }
        public int? Count { get; set; }
        public DateTime? Date { get; set; }
        public int? Number { get; set; }
    }
}