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
    
    public partial class INSUMO
    {
        public INSUMO()
        {
            this.DETALLEORDENCOMPRA = new HashSet<DETALLEORDENCOMPRA>();
            this.DETALLERECETA = new HashSet<DETALLERECETA>();
            this.MOVIMIENTO = new HashSet<MOVIMIENTO>();
        }
    
        public short ID_INSUMO { get; set; }
        public string NOMBREINSUMO { get; set; }
        public short STOCKACTUAL { get; set; }
        public short STOCKCRITICO { get; set; }
        public string ESTADO { get; set; }
        public string DESCRIPCIONINSUMO { get; set; }
    
        public virtual ICollection<DETALLEORDENCOMPRA> DETALLEORDENCOMPRA { get; set; }
        public virtual ICollection<DETALLERECETA> DETALLERECETA { get; set; }
        public virtual ICollection<MOVIMIENTO> MOVIMIENTO { get; set; }
    }
}