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
    
    public partial class DETALLEPEDIDO
    {
        public short CANTIDADPRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal TOTAL_DETALLE { get; set; }
        public string ESTADOPREPARACION { get; set; }
        public int ID_PEDIDOINDIV { get; set; }
        public int ID_PRODUCTO { get; set; }
    
        public virtual PEDIDOINDIVIDUAL PEDIDOINDIVIDUAL { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
