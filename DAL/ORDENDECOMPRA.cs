//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDENDECOMPRA
    {
        public ORDENDECOMPRA()
        {
            this.DETALLEORDENCOMPRA = new HashSet<DETALLEORDENCOMPRA>();
            this.MOVIMIENTOCAJA = new HashSet<MOVIMIENTOCAJA>();
        }
    
        public int NRO_ORDEN { get; set; }
        public System.DateTime FECHA { get; set; }
        public byte[] FIRMADIGITAL { get; set; }
        public string RUT_PROVEEDOR { get; set; }
        public short ID_SUSCURSAL { get; set; }
        public string ESTADO { get; set; }
    
        public virtual ICollection<DETALLEORDENCOMPRA> DETALLEORDENCOMPRA { get; set; }
        public virtual ICollection<MOVIMIENTOCAJA> MOVIMIENTOCAJA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
