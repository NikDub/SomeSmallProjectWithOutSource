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
    
    public partial class group_executor
    {
        public int ID { get; set; }
        public Nullable<int> ID_Executor { get; set; }
        public Nullable<int> ID_Group { get; set; }
        public Nullable<System.DateTime> Date_arr { get; set; }
        public Nullable<System.DateTime> Date_depart { get; set; }
        public string Role_stat { get; set; }
    
        public virtual executor executor { get; set; }
        public virtual groups groups { get; set; }
    }
}
