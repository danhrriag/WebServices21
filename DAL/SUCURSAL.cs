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
    
    public partial class SUCURSAL
    {
        public SUCURSAL()
        {
            this.ORDENDECOMPRA = new HashSet<ORDENDECOMPRA>();
        }
    
        public short ID_SUSCURSAL { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string TELEFONO { get; set; }
        public string ESTADO { get; set; }
        public int ID_DIRECCION { get; set; }
    
        public virtual DIRECCION DIRECCION { get; set; }
        public virtual ICollection<ORDENDECOMPRA> ORDENDECOMPRA { get; set; }
    }
}
