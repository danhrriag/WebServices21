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
    
    public partial class GARZON
    {
        public GARZON()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
        }
    
        public string RUT_GARZON { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CORREO { get; set; }
        public string CONTRASENA { get; set; }
    
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
    }
}
