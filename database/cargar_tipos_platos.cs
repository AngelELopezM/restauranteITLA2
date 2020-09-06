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
        int contador_mesa = 0;
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
            
            
            while (contador_mesa<5)
            {
                contador_mesa++;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM mesas WHERE id_mesa = @id_mesa", connection);
                    command.Parameters.AddWithValue("@id_mesa", contador_mesa);
                using (SqlDataReader reader = command.ExecuteReader())
                    if(reader.Read())
                    {
                        connection.Close();

                        
                        return contador_mesa;
                        
                    }
                    
                connection.Close();
            }

            contador_mesa = 0;
            return 0;
        }

        public void insertar_pedido(orden_persona orden) /*Cuando insertamos un pedido lo que estamoso haciendo es
           solamente agregar un pedido a la preorden de la mesa*/
        {
            try
            {
                int mesa = repositorio_mesa.instacia.mesa_en_uso;
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO pre_orden VALUES (@mesa,@cliente,@entrada " +
                    ",@plato_fuerte,@postre,@bebida)", connection);

                command.Parameters.AddWithValue("@mesa", mesa);
                command.Parameters.AddWithValue("@cliente", orden.cliente);
                command.Parameters.AddWithValue("@entrada", orden.entrada);
                command.Parameters.AddWithValue("@plato_fuerte", orden.plato_fuerte);
                command.Parameters.AddWithValue("@postre", orden.postre);
                command.Parameters.AddWithValue("@bebida", orden.bebida);
                command.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception)
            {

                
            }
            
            
        }
        public void agregar_orden() /*Cuando ejecutamos este comando entonces estamos despachando la orden
            por completo para que lal mesa sea servida*/
        {
            try
            {
                int mesa = repositorio_mesa.instacia.mesa_en_uso;
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO mesas SELECT * FROM pre_orden", connection);
                
                    command.ExecuteNonQuery();
                    connection.Close();
                


                    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }


        }

        public void cancelar_orden()
        {
            /*Aqui es donde se cancela la orden, de esta manera todo lo que estaba pendiente a ser servido
             va a ser eliminado de la lista de pendientes*/
            connection.Open();
            SqlCommand command= new SqlCommand("TRUNCATE TABLE pre_orden",connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public int revisar_mesa()
        {
            //Este sirve para que cuando el programa cargue revise si hay alguna mesa que esta ocupada
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            connection.Open();
            SqlCommand command2 = new SqlCommand("select count(*) from mesas where id_mesa = @mesa", connection);
            command2.Parameters.AddWithValue("@mesa",mesa);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            connection.Close();
                return 0;
        } 

        public int numero_pedidos()
        {
            /*Este es un metodo que vamos a utilizar para verificar cuantos pedidos tiene la mesa
             de esta manera podremos saber si ya hemos hecho los pedidos correspondientes al numero
             de clientes*/
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM pre_orden WHERE id_mesa = @mesa",connection);
            command.Parameters.AddWithValue("@mesa",mesa);
          using(SqlDataReader reader = command.ExecuteReader())
            {

                reader.Read();/*Para que las funciones del reader funcionen primero hay que iniciarlo
                como hice aqui arriba para despues poder utilizarlo*/
                int pedidos = reader.GetInt32(0);
                connection.Close();
                
                return pedidos;
                
                
                
                
            }

            
            return 0;
        }
        
        public List<orden_persona> Getorden(string cliente)
        {
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            orden_persona orden = new orden_persona();/*Creamos una instancia de la clase, para poder insertar
            los datos que vamos a conseguir desde la base y despues vamos a crear el list para ingresar los datos
            y que el metodo los pueda devolver*/
            List<orden_persona> l_orden = new List<orden_persona>();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM mesas WHERE nombre_cliente = @cliente"+
                " and id_mesa = @mesa",connection);
            
            command.Parameters.AddWithValue("@cliente", cliente);
            command.Parameters.AddWithValue("@mesa", mesa);
            
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();  
            orden.cliente = cliente;
            orden.entrada = reader["entrada"].ToString();
            orden.plato_fuerte = reader["plato_fuerte"].ToString();
            orden.postre = reader["postre"].ToString();
            orden.bebida = reader["bebida"].ToString();
            
            l_orden.Add(orden);
            connection.Close();
            return l_orden;
        }

        public void eliminar_pedido(string cliente)
        {
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            connection.Open();
            SqlCommand command2 = new SqlCommand("DELETE mesas WHERE nombre_cliente = @cliente" +
                " and id_mesa = @mesa", connection);
            /*Para cuidar que los datos no se nos dupliquen en ver de hacer un update de los datos
             lo que vamos a hacer es que lo vamos a borrar y vamos a reincertarlo mas tarde cuando lo 
             medifiquemos*/
            command2.Parameters.AddWithValue("@cliente", cliente);
            command2.Parameters.AddWithValue("@mesa", mesa);
            command2.ExecuteNonQuery();
            connection.Close();
        }

        public void limpiar_mesa()
        {
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE mesas WHERE id_mesa = @mesa",connection);
            command.Parameters.AddWithValue("@mesa",mesa);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<orden_persona> Getclientes()
        {
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            /*Aqui cree un objeto de tipo orden persona
            solo para agregar el nombre del cliente y despues pasarlo al listado de tipo orden persona
            que en este caso solo se va a utilizar para devolver el nombre de los clientes que estan en la
            mesa para de esta manera cargar el combobox*/
            List<orden_persona> nombre_cliente = new List<orden_persona>();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT nombre_cliente FROM mesas WHERE id_mesa = @mesa",connection);
            command.Parameters.AddWithValue("@mesa",mesa);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                orden_persona cliente = new orden_persona() {cliente = reader.GetString(0) };
                nombre_cliente.Add(cliente);
            }
            
            connection.Close();
            return nombre_cliente;
        }

      public void actualizar_orden(orden_persona orden)
        {
            try
            {
                int mesa = repositorio_mesa.instacia.mesa_en_uso;
                connection.Open();
                SqlCommand command = new SqlCommand("update mesas set entrada =@entrada, plato_fuerte = plato_fuerte"+
                    ", postre=@postre, bebida=@bebida WHERE id_mesa = @mesa and nombre_cliente = @cliente", connection);

                command.Parameters.AddWithValue("@mesa", mesa);
                command.Parameters.AddWithValue("@cliente", orden.cliente);
                command.Parameters.AddWithValue("@entrada", orden.entrada);
                command.Parameters.AddWithValue("@plato_fuerte", orden.plato_fuerte);
                command.Parameters.AddWithValue("@postre", orden.postre);
                command.Parameters.AddWithValue("@bebida", orden.bebida);
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {


            }
        }
    }
}
