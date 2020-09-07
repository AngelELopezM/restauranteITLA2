using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restauranteITLA_2.combobox;
using database;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace restauranteITLA_2
{
    public partial class frm_menu_pedidos : Form
    {
        private cargar_tipos_platos tipos_platos;
        private SqlConnection connection;
        private int numero_de_personas = 0;
        public frm_menu_pedidos()
        {
            InitializeComponent();
            tipos_platos = new cargar_tipos_platos();
            var connectionstring = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionstring);
        }

        #region events
        private void frm_menu_pedidos_Load(object sender, EventArgs e)
        {

            bool ocupada = mesa_ocupada.instacia.ocupada;
            if (ocupada==true)
            {
                tb_cliente.ReadOnly = true;
                numero_clientes();
            }//Cuando la mesa cargue como ocupada, entonces, el nombre dle cliente,
            //no sera editable
            Load_combobox();
            Load_cbclientes();
            
            
        }
        private void btn_seleccionar_categoria_Click(object sender, EventArgs e)
        {
            limpiar_lb();
            Load_Cbmenu();
            
        }
        private void lb_menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var plato = lb_menu.SelectedItem.ToString();

                lb_pedido_clientes.Items.Add(plato);
            }
            catch (Exception)
            {

                
            }
            
        }
        
        private void btn_ingresar_pedido_Click(object sender, EventArgs e)
        {
            bool ocupada = mesa_ocupada.instacia.ocupada;
            if (ocupada==true)
            {
                editar_pedido();
            }
            else
            {
                agregar_pedido();
            }
            
            /*Despues de que agregamos el pedido confirmamos que el numero de pedido
             que tengamos sea igual al numero de cliente, cuando lo sea entonces vamos a poder
             despachar toda la orden*/
            int numero_de_pedidos = tipos_platos.numero_pedidos();
            if (numero_de_pedidos ==numero_de_personas)
            {
                bt_despachar_orden.Enabled = true;
            }
        }
        private void lb_pedido_clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = lb_pedido_clientes.SelectedIndex;/*Aqui primero recojemos el indice del objeto
            que vamos a eliminar, para despues proceder a eliminarlo*/
                lb_pedido_clientes.Items.RemoveAt(index);/*Aqui usamos el indice recojido para eliminar*/
            }
            catch (Exception)
            {

                
            }
            
        }
        private void bt_cancelar_pedido_Click(object sender, EventArgs e)
        {
            tipos_platos.cancelar_orden();
            frm_menu_principal principal = new frm_menu_principal();
            principal.Show();
            this.Hide();
        }
        /*Cuando le demos click a los radio buttons entonces nos indicara el numero de personas que hay
         en la mesa y tambien se habilitara el boton para ingresar pedidos*/
        private void rdb_1_persona_CheckedChanged(object sender, EventArgs e)
        {
            numero_de_personas = 1;
            btn_ingresar_pedido.Enabled = true;
        }

        private void rdb_2_persona_CheckedChanged(object sender, EventArgs e)
        {
            numero_de_personas = 2;
            btn_ingresar_pedido.Enabled = true;
        }

        private void rdb_3_persona_CheckedChanged(object sender, EventArgs e)
        {
            numero_de_personas = 3;
            btn_ingresar_pedido.Enabled = true;
        }

        private void rdb_4_persona_CheckedChanged(object sender, EventArgs e)
        {
            numero_de_personas = 4;
            btn_ingresar_pedido.Enabled = true;
        }
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            buscar_orden();
            /*Aqui buscamos la orden y despues eliminamos esa orden bajo el nombre que buscamos
             de esta manera no se duplican los datos y en vez de hace un update lo que hacemos es
             que jalamos los datos y los volvemos a incertar*/
            
            tb_cliente.Text = cb_cliente.SelectedItem.ToString();
        }
        private void bt_despachar_orden_Click(object sender, EventArgs e)
        {
            try
            
            {
                tipos_platos.agregar_orden();/*Aqui primero agregamos la orden y despues eliminamos la orden
                de la tabla de pre_ordenes*/
                tipos_platos.cancelar_orden();
                MessageBox.Show("Orden agregada");
                frm_menu_principal principal = new frm_menu_principal();
                principal.Show();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion

        #region methods
        private void Load_combobox()
        {
            comboboxitem opcion_defecto = new comboboxitem
            {
                value = null,
                text = "Seleccione una opcion"
            };
            cb_menu.Items.Add(opcion_defecto);
            cb_menu.SelectedItem = opcion_defecto;

            List<tipo_plato> platos = tipos_platos.GetAll();

            foreach (var item in platos)
            {
                comboboxitem combobox_tiem = new comboboxitem
                {
                    text = item.tipo,
                    value = item.id

                };
                cb_menu.Items.Add(combobox_tiem);
            }


        }

        private void Load_Cbmenu()
        {
            
            comboboxitem opcion_seleccionada = cb_menu.SelectedItem as comboboxitem;
            
             List<platos_menu> platos = tipos_platos.Get_platos(Convert.ToInt32(opcion_seleccionada.value));
            foreach (var item in platos)
            {
                lb_menu.Items.Add(item.plato);
            }
        }

        private void limpiar_lb()
        {
            
            if (lb_menu.Items.Count !=0)
            {
            
                    lb_menu.Items.Clear();
            
            }
        }
        private void agregar_pedido()
        {
            orden_persona orden = new orden_persona();
            int numero_de_platos = lb_pedido_clientes.Items.Count;
            if (numero_de_platos == 4 && tb_cliente.Text!="")
            {
                orden.cliente = tb_cliente.Text;
                orden.entrada = lb_pedido_clientes.Items[0].ToString();
                orden.plato_fuerte = lb_pedido_clientes.Items[1].ToString();
                orden.postre = lb_pedido_clientes.Items[2].ToString();
                
                orden.bebida = lb_pedido_clientes.Items[3].ToString();
                tipos_platos.insertar_pedido(orden);
                MessageBox.Show("Pedido agregado");
                lb_pedido_clientes.Items.Clear();
                tb_cliente.Clear();
                
            }
            else
            {
                MessageBox.Show("Verifique la orden para poder someterla");
            }
            
            //tipos_platos.revisar_mesa();
        }

        private void buscar_orden()
        {
            List<orden_persona> orden = tipos_platos.Getorden(cb_cliente.Text);
            //primero limpiamos el lb_pedidos
            lb_pedido_clientes.Items.Clear();
            lb_pedido_clientes.Items.Add(orden[0].entrada);
            lb_pedido_clientes.Items.Add(orden[0].plato_fuerte);
            lb_pedido_clientes.Items.Add(orden[0].postre);
            lb_pedido_clientes.Items.Add(orden[0].bebida);
        }

        private void Load_cbclientes()
        {
            List < orden_persona > cliente = tipos_platos.Getclientes();
            foreach (var item in cliente)
            {
                cb_cliente.Items.Add(item.cliente);
            }
                    
        }
        private void editar_pedido()
        {
            orden_persona orden = new orden_persona();
            int numero_de_platos = lb_pedido_clientes.Items.Count;
            if (numero_de_platos == 4 && tb_cliente.Text != "")
            {
                orden.cliente = tb_cliente.Text;
                orden.entrada = lb_pedido_clientes.Items[0].ToString();
                orden.plato_fuerte = lb_pedido_clientes.Items[1].ToString();
                orden.postre = lb_pedido_clientes.Items[2].ToString();

                orden.bebida = lb_pedido_clientes.Items[3].ToString();
                tipos_platos.actualizar_orden(orden);
                MessageBox.Show("Pedido actualizado");
                lb_pedido_clientes.Items.Clear();
                tb_cliente.Clear();

            }
            else
            {
                MessageBox.Show("Verifique la orden para poder someterla");
            }
        }
        private int numero_clientes()
        {
            /*Este metodo sirve para que cuando la mesa cargue llena, de manera automatica se seleccione
             el numero de clientes que tiene la mesa*/
            int pedidos = tipos_platos.numero_clientes();
            switch (pedidos)
            {
                case 1:
                    rdb_1_persona.Checked = true;
                    break;
                case 2:
                    rdb_2_persona.Checked = true;
                    break;
                case 3:
                    rdb_3_persona.Checked = true;
                    break;
                case 4:
                    rdb_4_persona.Checked = true;
                    break;

                default:
                    break;
            }
            
            return pedidos;
        }

        #endregion

        
    }
}
