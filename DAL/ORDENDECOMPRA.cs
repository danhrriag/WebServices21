//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
