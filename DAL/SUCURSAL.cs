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
    
    public partial class SUCURSAL
    {
        public SUCURSAL()
        {
            this.ORDENDECOMPRA = new HashSet<ORDENDECOMPRA>();
        }
    
        public short ID_SUSCURSAL { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string CIUDAD { get; set; }
        public string ESTADO { get; set; }
    
        public virtual ICollection<ORDENDECOMPRA> ORDENDECOMPRA { get; set; }
    }
}
