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
    
    public partial class People_Title
    {
        public int ID { get; set; }
        public Nullable<int> ID_Sport_type { get; set; }
        public Nullable<int> ID_People { get; set; }
        public Nullable<int> ID_Title { get; set; }
    
        public virtual People People { get; set; }
        public virtual Sport_type Sport_type { get; set; }
        public virtual Title Title { get; set; }
    }
}