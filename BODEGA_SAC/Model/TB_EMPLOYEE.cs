//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BODEGA_SAC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_EMPLOYEE()
        {
            this.TB_SALE = new HashSet<TB_SALE>();
        }
    
        public int ID_EMPLOYEE { get; set; }
        public string NAME_EMPLOYEE { get; set; }
        public string LAST_NAME_EMPLOYEE { get; set; }
        public string DNI_EMPLOYEE { get; set; }
        public int STATUS_EMPLOYEE { get; set; }
        public int ID_ROLE_EMPLOYEE { get; set; }
    
        public virtual TB_ROLE_EMPLOYEE TB_ROLE_EMPLOYEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SALE> TB_SALE { get; set; }
    }
}
