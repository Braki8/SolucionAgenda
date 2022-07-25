using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using capa_Entidad;
using System.Data;


namespace Capa_Negocio
{
    public class N_Empleados
    {

        D_Empleados objdato = new D_Empleados();

        public DataTable N_listado()
        {
            return objdato.D_listado();
        }

    }
}
