//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArteEmpresarialPROY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta_de_Detalle
    {
        public long idVentaDetalle { get; set; }
        public long idVenta { get; set; }
        public int idArticulo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Ventas Ventas { get; set; }
    }
}
