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
