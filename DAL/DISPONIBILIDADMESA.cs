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
    
    public partial class DISPONIBILIDADMESA
    {
        public System.DateTime FECHAHORA { get; set; }
        public int ID_RESERVA { get; set; }
        public short NROMESA { get; set; }
    
        public virtual MESA MESA { get; set; }
        public virtual RESERVA RESERVA { get; set; }
    }
}
