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
            Load_combobox();
            lb_pedido_clientes.Items.Add("prueba");
            //Me quede aqui metiendole datos de los clientes
        }
        private void btn_seleccionar_categoria_Click(object sender, EventArgs e)
        {
            Load_Cbmenu();
            
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

        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
