using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaData;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario obj_usuario = new CD_Usuario(); //instancia a la clase Cd_Usuario
        public List<Usuario> Listar() //mismo metodo de la capa de datos
        {
            return obj_usuario.Listar();  //retornar la lista que tiene la clase CD_Usuario
        }
    }
}
