//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Materialy.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buy()
        {
            this.Buy_Details = new HashSet<Buy_Details>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Id_Employee { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy_Details> Buy_Details { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
