using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitions.ModelsForShow
{
    internal class DischargeShow
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Разряд")]
        public string Discharge { get; set; }
        [System.ComponentModel.DisplayName("Вид Спорта")]
        public string SportType { get; set; }
    }
}
