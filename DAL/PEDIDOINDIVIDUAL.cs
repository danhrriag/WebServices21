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
    
    public partial class PEDIDOINDIVIDUAL
    {
        public PEDIDOINDIVIDUAL()
        {
            this.DETALLEPEDIDO = new HashSet<DETALLEPEDIDO>();
        }
    
        public int ID_PEDIDOINDIV { get; set; }
        public System.DateTime FECHAYHORA { get; set; }
        public decimal TOTALINDIV { get; set; }
        public string ESTADO { get; set; }
        public int ID_PEDIDO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<DETALLEPEDIDO> DETALLEPEDIDO { get; set; }
        public virtual PEDIDO PEDIDO { get; set; }
    }
}
