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
        public decimal STOCKACTUAL { get; set; }
        public decimal STOCKCRITICO { get; set; }
        public string UNIDAD_MEDIDA { get; set; }
        public string ESTADO { get; set; }
        public string DESCRIPCIONINSUMO { get; set; }
    
        public virtual ICollection<DETALLEORDENCOMPRA> DETALLEORDENCOMPRA { get; set; }
        public virtual ICollection<DETALLERECETA> DETALLERECETA { get; set; }
        public virtual ICollection<MOVIMIENTO> MOVIMIENTO { get; set; }
    }
}
