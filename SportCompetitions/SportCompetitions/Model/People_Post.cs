//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCompetitions.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class People_Post
    {
        public int ID { get; set; }
        public Nullable<int> ID_people { get; set; }
        public Nullable<int> ID_post { get; set; }
        public Nullable<int> ID_sport_type { get; set; }
        public Nullable<System.DateTime> Start_date { get; set; }
        public Nullable<System.DateTime> End_date { get; set; }
    
        public virtual People People { get; set; }
        public virtual Post Post { get; set; }
        public virtual Sport_type Sport_type { get; set; }
    }
}
