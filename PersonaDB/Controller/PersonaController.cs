using Microsoft.Data.SqlClient;
using PersonaDB.Context;
using PersonaDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDB.Controller
{
    class PersonaController : IPersonaController
    {
        
    
        private Conection conexion = new Conection();


        public PersonaController() { }


        public List<Social> Leer()
        {
            List<Social> personajes = new List<Social>();
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Obtenersl";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        personajes.Add(new Social()
                        {
                            idsocial = Convert.ToInt32(reader["idsocial"]),
                            nombre = reader["nombre"].ToString(),
                            apellido = reader["apellido"].ToString(),
                            arcana = reader["arcana"].ToString(),
                            persona = reader["persona"].ToString(),
                            grupo = reader["grupo"].ToString()
                        });
                    }
                }
                return personajes;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Insertar(Social social)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Insertarsl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", social.nombre);
                    cmd.Parameters.AddWithValue("@apellido", social.apellido);
                    cmd.Parameters.AddWithValue("@arcana", social.arcana);
                    cmd.Parameters.AddWithValue("@persona", social.persona);
                    cmd.Parameters.AddWithValue("@grupo", social.grupo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
