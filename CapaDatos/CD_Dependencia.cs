using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CD_Dependencia
    {
        public List<Dependencia> Listar()
        {
            List<Dependencia> lista = new List<Dependencia>();

            try

            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "SELECT Id, Descripcion, Edificio FROM dbo.DEPENDENCIA;";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Dependencia()
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Edificio = Convert.ToBoolean(dr["Edificio"])
                                }
                             );

                        }
                    }
                }
            }
            catch
            {
                lista = new List<Dependencia>();
            }
            return lista;
        }
    }
}
