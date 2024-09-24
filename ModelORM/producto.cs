//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.compra_detalle = new HashSet<compra_detalle>();
            this.venta_detalle = new HashSet<venta_detalle>();
        }
    
        public int id { get; set; }
        public string sku { get; set; }
        public string codigoBarra { get; set; }
        public int stock { get; set; }
        public int stock_minimo { get; set; }
        public decimal precio { get; set; }
        public int id_estado { get; set; }
        public string observaciones { get; set; }
        public int id_proveedor { get; set; }
        public int id_categoria { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaUltModificacion { get; set; }
    
        public virtual categoria categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_detalle> compra_detalle { get; set; }
        public virtual estado estado { get; set; }
        public virtual proveedor proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_detalle> venta_detalle { get; set; }
    }
}
