using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaData
{
    public class CD_Usuario // este metodo lo llamara la capa de negocio
    {
        public List<Usuario> Listar() { //devolver una lista de usuarios
            List<Usuario> lista=new List<Usuario>(); //creando una lista vacia

            using (SqlConnection oconexion = new SqlConnection("Conexion.cadena")) //conectarme a la bd con la cadena de conexion
            {   //peticion hacia loa base de datos
                try
                {
                 string query = "select IdUsuario,Documento,NombreCompleto,Correo,Clave,Estado from Usuario"; //consulta a la bd
                    SqlCommand cmd = new SqlCommand(query,oconexion); //se encarga de ejecutar los comandos
                 cmd.CommandType = CommandType.Text; //indicando que el tipo de comando es un texto
                 oconexion.Open(); //abrir la conexion para que pueda ejecutar el comando
                    using (SqlDataReader dr= cmd.ExecuteReader()) //ejecutar el encargado de leer el resultado del comando
                    {
                        while (dr.Read())
                        {
                            //mientras lee almacena cada fila en mi lista 
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = Convert.ToInt32(dr["Clave"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            }) ;
                        }
                    }
                }catch(Exception ex) {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
