using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitions.ModelsForShow
{
    internal class Person
    {
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Имя")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Фамилия")]
        public string Surname { get; set; }
        [System.ComponentModel.DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [System.ComponentModel.DisplayName("Страна")]
        public string Country { get; set; }
        [System.ComponentModel.DisplayName("Город")]
        public string City { get; set; }
        [System.ComponentModel.DisplayName("Дата рождения")]
        public DateTime? Birth_date { get; set; }
        [System.ComponentModel.DisplayName("Национальность")]
        public string Nationality { get; set; }

    }
}
