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
    
    public partial class MOVIMIENTO
    {
        public int ID_MOVIMIENTO { get; set; }
        public System.DateTime FECHA { get; set; }
        public short CANTIDAD { get; set; }
        public string TIPO { get; set; }
        public string RUT_PERSONA { get; set; }
        public short ID_INSUMO { get; set; }
    
        public virtual INSUMO INSUMO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}
