using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace database
{
    
  public  class cargar_tipos_platos
    {
        private SqlConnection connection;
        
        public cargar_tipos_platos()
        {
            var connectionstring = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionstring);
        }

        public List<tipo_plato> GetAll()
        {
            List<tipo_plato> listado = new List<tipo_plato>();

            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT * FROM tipos_platos", connection)) 
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    listado.Add(new tipo_plato
                    {
                        id = reader.GetInt32(0),
                        tipo = reader.GetString(1)

                    });
                }
            }
            connection.Close();
                return listado;
        }

        public List<platos_menu> Get_platos(int index)
        {
            List<platos_menu> platos = new List<platos_menu>();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM platos_menu WHERE tipo_plato = @tipo", connection);
            command.Parameters.AddWithValue("@tipo", index);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    platos_menu plato = new platos_menu {plato = reader.GetString(1) };

                    platos.Add(plato);
                }
            }
                connection.Close();
                return platos;
           
        }

        public int estado_mesas()
        {
            int contador_mesa = 0;
            connection.Open();
            while (contador_mesa<5)
            {
                
                SqlCommand command = new SqlCommand("SELECT * FROM mesas WHERE id_mesa = @id_mesa", connection);
                    command.Parameters.AddWithValue("@id_mesa", contador_mesa);
                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        return contador_mesa;
                    }
                    contador_mesa++;
                
            }
            connection.Close();
            return 0;
        }

        public int insertar_pedido() /*Cuando insertamos un pedido lo que estamoso haciendo es
           solamente agregar un pedido a la mesa*/
        {
            int mesa = 
            return 0;
        }

    }
}
