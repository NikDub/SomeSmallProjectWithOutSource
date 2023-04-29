using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitions.ModelsForShow
{
    internal class TitleShow
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Титул")]
        public string Title { get; set; }
        [System.ComponentModel.DisplayName("Вид Спорта")]
        public string SportType { get; set; }
    }
}
