//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cursovou.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServisePage
    {
        public int IDServise { get; set; }
        public string NazvanieYslygi { get; set; }
        public int StoimostYslygi { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Market Market { get; set; }
    }
}
