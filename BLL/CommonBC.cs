using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommonBC
    {
        private static Entities _modeloEntities;
        public static Entities ModeloEntities
        {
            get
            {
                _modeloEntities = new Entities();
                return _modeloEntities;
            }
        }
    }
}
