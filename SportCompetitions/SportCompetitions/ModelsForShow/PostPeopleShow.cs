using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitions.ModelsForShow
{
    internal class PostPeopleShow
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public string SportType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
