//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupAndSonger.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class places
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public places()
        {
            this.buy_tick = new HashSet<buy_tick>();
        }
    
        public int ID { get; set; }
        public string Name_loc { get; set; }
        public string Name_place { get; set; }
        public Nullable<int> Price_tick { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> ID_Country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buy_tick> buy_tick { get; set; }
        public virtual country country { get; set; }
    }
}
