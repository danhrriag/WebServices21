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
    
    public partial class RESERVA
    {
        public RESERVA()
        {
            this.DISPONIBILIDADMESA = new HashSet<DISPONIBILIDADMESA>();
        }
    
        public int ID_RESERVA { get; set; }
        public System.DateTime FECHA_REALIZACION { get; set; }
        public System.DateTime FECHA_RESERVA { get; set; }
        public short CANTIDADPERSONAS { get; set; }
        public string ESTADO { get; set; }
        public string RUT_PERSONA { get; set; }
    
        public virtual ICollection<DISPONIBILIDADMESA> DISPONIBILIDADMESA { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}