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
        private void btn_mesa1_Click(object sender, EventArgs e)
        {

        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            estados_mesas();
            
        }
        #endregion

        #region methos
        private void estados_mesas()
        {
            switch (data_logic.estado_mesas())
            {
                case ((int)mesas.mesa1):
                    btn_mesa1.BackColor = Color.Yellow;
                    break;
                case ((int)mesas.mesa2):
                    btn_mesa2.BackColor = Color.Yellow;
                    break;
                case ((int)mesas.mesa3):
                    btn_mesa3.BackColor = Color.Yellow;
                    break;
                case ((int)mesas.mesa4):
                    btn_mesa4.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
