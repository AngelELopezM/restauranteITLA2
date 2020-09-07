using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database;
namespace restauranteITLA_2
{
    
    public partial class frm_menu_principal : Form
    {
        enum mesas
        {
            mesa1 = 1,
            mesa2,
            mesa3,
            mesa4
        }
        
        private cargar_tipos_platos data_logic;
        public frm_menu_principal()
        {
            data_logic = new cargar_tipos_platos();
            InitializeComponent();

        }


        #region events

        private void btn_limpiar_mesa_Click(object sender, EventArgs e)
        {
            limpiar_mesa();
            estados_mesas();
            btn_reanudar_orden.Enabled = false;
        }
        private void btn_reanudar_orden_Click(object sender, EventArgs e)
        {
            mesa_ocupada.instacia.ocupada = true;//Esto es para que se nos carguen las opciones
            //de mesa ocupada en el prox formulario
            frm_menu_pedidos pedidos = new frm_menu_pedidos();
            pedidos.Show();
            this.Hide();
            
        }
        private void btn_mesa1_Click(object sender, EventArgs e)
        {
            repositorio_mesa.instacia.mesa_en_uso = 1;
            if (btn_mesa1.BackColor == Color.Yellow)
            {
                btn_nueva_orden.Enabled = false;
                btn_reanudar_orden.Enabled = true;
            }
            else
            {
                btn_reanudar_orden.Enabled = false;
                btn_nueva_orden.Enabled = true;
            }

        }
        private void btn_mesa2_Click(object sender, EventArgs e)
        {
            repositorio_mesa.instacia.mesa_en_uso = 2;
            if (btn_mesa2.BackColor == Color.Yellow)
            {
                btn_nueva_orden.Enabled = false;
                btn_reanudar_orden.Enabled = true;
            }
            else
            {
                btn_reanudar_orden.Enabled = false;
                btn_nueva_orden.Enabled = true;
            }
        }
        private void btn_mesa3_Click(object sender, EventArgs e)
        {
            repositorio_mesa.instacia.mesa_en_uso = 3;
            if (btn_mesa3.BackColor == Color.Yellow)
            {
                btn_nueva_orden.Enabled = false;
                btn_reanudar_orden.Enabled = true;
            }
            else
            {
                btn_reanudar_orden.Enabled = false;
                btn_nueva_orden.Enabled = true;
            }
        }
        private void btn_mesa4_Click(object sender, EventArgs e)
        {
            repositorio_mesa.instacia.mesa_en_uso = 4;
            if (btn_mesa4.BackColor == Color.Yellow)
            {
                btn_nueva_orden.Enabled = false;
                btn_reanudar_orden.Enabled = true;
            }
            else
            {
                btn_reanudar_orden.Enabled = false;
                btn_nueva_orden.Enabled = true;
            }
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            estados_mesas();
            
        }
        private void btn_nueva_orden_Click(object sender, EventArgs e)
        {
            ordernar();
           mesa_ocupada.instacia.ocupada = false;
        }
        #endregion

        #region methos

        private void ordernar()
        {
            frm_menu_pedidos pedidos = new frm_menu_pedidos();
            pedidos.Show();
            this.Hide();
        }
        private void estados_mesas()
        {
            /*aqui si el metodo que tiene el contador lee algo, va a retornar el numero de la mesa
             que leyo, de lo contrati*/
            switch (data_logic.estado_mesas())
            {
                case ((int)mesas.mesa1):
                    btn_mesa1.BackColor = Color.Yellow;

                    estados_mesas();
                    break;
                case ((int)mesas.mesa2):
                    btn_mesa2.BackColor = Color.Yellow;
                    estados_mesas();
                    break;
                case ((int)mesas.mesa3):
                    btn_mesa3.BackColor = Color.Yellow;
                    estados_mesas();
                    break;
                case ((int)mesas.mesa4):
                    btn_mesa4.BackColor = Color.Yellow;
                    
                    break;
                default:
                    
                    break;
                    /*Aqui el metodo se llama a si mismo para que al entrar  en el switch
                    No se corte todo sino que realize la accion y pueda seguir verificando las
                     otras mesas que quedan pendiente   */
            }
        }

        private void limpiar_mesa()
        {
            /*Cuando estamos limpiando la mesa ejecutamos Switch para que de esta manera la mesa que se limpia
             vuelva a tener el estado de disponible*/
            int mesa = repositorio_mesa.instacia.mesa_en_uso;
            if (mesa!=0)
            {
                var opcion = MessageBox.Show("Seguro que desea limpiar la mesa #"+mesa,"Restaurante",MessageBoxButtons.YesNo);
                if (opcion == DialogResult.Yes )
                {
                    data_logic.limpiar_mesa();
                    switch (mesa)
                    {
                        case 1:
                            btn_mesa1.BackColor = Color.Green;
                            break;
                        case 2:
                            btn_mesa2.BackColor = Color.Green;
                            break;
                        case 3:
                            btn_mesa3.BackColor = Color.Green;
                            break;
                        case 4:
                            btn_mesa4.BackColor = Color.Green;
                            break;
                        default:
                            break;
                    }
                }
            }
        }



        #endregion

        
    }
}
