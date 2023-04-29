using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitions.ModelsForShow
{
    internal class AccidentShow
    {
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Имя")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Дата")]
        public DateTime? Date { get; set; }
    }
}
