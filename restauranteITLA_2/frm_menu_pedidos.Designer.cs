namespace restauranteITLA_2
{
    partial class frm_menu_pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_despachar_orden = new System.Windows.Forms.Button();
            this.gb_numero_personas = new System.Windows.Forms.GroupBox();
            this.rdb_4_persona = new System.Windows.Forms.RadioButton();
            this.rdb_3_persona = new System.Windows.Forms.RadioButton();
            this.rdb_2_persona = new System.Windows.Forms.RadioButton();
            this.rdb_1_persona = new System.Windows.Forms.RadioButton();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar_categoria = new System.Windows.Forms.Button();
            this.lb_menu = new System.Windows.Forms.ListBox();
            this.cb_menu = new System.Windows.Forms.ComboBox();
            this.bt_cancelar_pedido = new System.Windows.Forms.Button();
            this.lb_pedido_clientes = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ingresar_pedido = new System.Windows.Forms.Button();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_numero_personas.SuspendLayout();
            this.gb_menu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.41505F));
            this.tableLayoutPanel1.Controls.Add(this.bt_despachar_orden, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_numero_personas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb_menu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_cancelar_pedido, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_pedido_clientes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53881F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.46119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bt_despachar_orden
            // 
            this.bt_despachar_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_despachar_orden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_despachar_orden.Enabled = false;
            this.bt_despachar_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_despachar_orden.ForeColor = System.Drawing.Color.White;
            this.bt_despachar_orden.Location = new System.Drawing.Point(280, 441);
            this.bt_despachar_orden.Name = "bt_despachar_orden";
            this.bt_despachar_orden.Size = new System.Drawing.Size(594, 48);
            this.bt_despachar_orden.TabIndex = 6;
            this.bt_despachar_orden.Text = "Despachar orden";
            this.bt_despachar_orden.UseVisualStyleBackColor = false;
            this.bt_despachar_orden.Click += new System.EventHandler(this.bt_despachar_orden_Click);
            // 
            // gb_numero_personas
            // 
            this.gb_numero_personas.Controls.Add(this.rdb_4_persona);
            this.gb_numero_personas.Controls.Add(this.rdb_3_persona);
            this.gb_numero_personas.Controls.Add(this.rdb_2_persona);
            this.gb_numero_personas.Controls.Add(this.rdb_1_persona);
            this.gb_numero_personas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_numero_personas.Location = new System.Drawing.Point(3, 3);
            this.gb_numero_personas.Name = "gb_numero_personas";
            this.gb_numero_personas.Size = new System.Drawing.Size(271, 119);
            this.gb_numero_personas.TabIndex = 3;
            this.gb_numero_personas.TabStop = false;
            this.gb_numero_personas.Text = "Numero de personas";
            // 
            // rdb_4_persona
            // 
            this.rdb_4_persona.AutoSize = true;
            this.rdb_4_persona.Location = new System.Drawing.Point(201, 48);
            this.rdb_4_persona.Name = "rdb_4_persona";
            this.rdb_4_persona.Size = new System.Drawing.Size(37, 21);
            this.rdb_4_persona.TabIndex = 3;
            this.rdb_4_persona.TabStop = true;
            this.rdb_4_persona.Text = "4";
            this.rdb_4_persona.UseVisualStyleBackColor = true;
            this.rdb_4_persona.CheckedChanged += new System.EventHandler(this.rdb_4_persona_CheckedChanged);
            // 
            // rdb_3_persona
            // 
            this.rdb_3_persona.AutoSize = true;
            this.rdb_3_persona.Location = new System.Drawing.Point(201, 21);
            this.rdb_3_persona.Name = "rdb_3_persona";
            this.rdb_3_persona.Size = new System.Drawing.Size(37, 21);
            this.rdb_3_persona.TabIndex = 2;
            this.rdb_3_persona.TabStop = true;
            this.rdb_3_persona.Text = "3";
            this.rdb_3_persona.UseVisualStyleBackColor = true;
            this.rdb_3_persona.CheckedChanged += new System.EventHandler(this.rdb_3_persona_CheckedChanged);
            // 
            // rdb_2_persona
            // 
            this.rdb_2_persona.AutoSize = true;
            this.rdb_2_persona.Location = new System.Drawing.Point(9, 48);
            this.rdb_2_persona.Name = "rdb_2_persona";
            this.rdb_2_persona.Size = new System.Drawing.Size(37, 21);
            this.rdb_2_persona.TabIndex = 1;
            this.rdb_2_persona.TabStop = true;
            this.rdb_2_persona.Text = "2";
            this.rdb_2_persona.UseVisualStyleBackColor = true;
            this.rdb_2_persona.CheckedChanged += new System.EventHandler(this.rdb_2_persona_CheckedChanged);
            // 
            // rdb_1_persona
            // 
            this.rdb_1_persona.AutoSize = true;
            this.rdb_1_persona.Location = new System.Drawing.Point(9, 21);
            this.rdb_1_persona.Name = "rdb_1_persona";
            this.rdb_1_persona.Size = new System.Drawing.Size(37, 21);
            this.rdb_1_persona.TabIndex = 0;
            this.rdb_1_persona.TabStop = true;
            this.rdb_1_persona.Text = "1";
            this.rdb_1_persona.UseVisualStyleBackColor = true;
            this.rdb_1_persona.CheckedChanged += new System.EventHandler(this.rdb_1_persona_CheckedChanged);
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.btn_seleccionar_categoria);
            this.gb_menu.Controls.Add(this.lb_menu);
            this.gb_menu.Controls.Add(this.cb_menu);
            this.gb_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_menu.Location = new System.Drawing.Point(3, 128);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(271, 307);
            this.gb_menu.TabIndex = 4;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "Menu";
            // 
            // btn_seleccionar_categoria
            // 
            this.btn_seleccionar_categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_seleccionar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_categoria.Location = new System.Drawing.Point(3, 42);
            this.btn_seleccionar_categoria.Name = "btn_seleccionar_categoria";
            this.btn_seleccionar_categoria.Size = new System.Drawing.Size(265, 82);
            this.btn_seleccionar_categoria.TabIndex = 3;
            this.btn_seleccionar_categoria.Text = "Seleccionar";
            this.btn_seleccionar_categoria.UseVisualStyleBackColor = true;
            this.btn_seleccionar_categoria.Click += new System.EventHandler(this.btn_seleccionar_categoria_Click);
            // 
            // lb_menu
            // 
            this.lb_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_menu.FormattingEnabled = true;
            this.lb_menu.ItemHeight = 16;
            this.lb_menu.Location = new System.Drawing.Point(3, 124);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(265, 180);
            this.lb_menu.TabIndex = 2;
            this.lb_menu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_menu_MouseDoubleClick);
            // 
            // cb_menu
            // 
            this.cb_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_menu.FormattingEnabled = true;
            this.cb_menu.Location = new System.Drawing.Point(3, 18);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(265, 24);
            this.cb_menu.TabIndex = 1;
            // 
            // bt_cancelar_pedido
            // 
            this.bt_cancelar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_cancelar_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_cancelar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_pedido.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar_pedido.Location = new System.Drawing.Point(3, 441);
            this.bt_cancelar_pedido.Name = "bt_cancelar_pedido";
            this.bt_cancelar_pedido.Size = new System.Drawing.Size(271, 48);
            this.bt_cancelar_pedido.TabIndex = 5;
            this.bt_cancelar_pedido.Text = "Cancelar pedido";
            this.bt_cancelar_pedido.UseVisualStyleBackColor = false;
            this.bt_cancelar_pedido.Click += new System.EventHandler(this.bt_cancelar_pedido_Click);
            // 
            // lb_pedido_clientes
            // 
            this.lb_pedido_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_pedido_clientes.FormattingEnabled = true;
            this.lb_pedido_clientes.ItemHeight = 16;
            this.lb_pedido_clientes.Location = new System.Drawing.Point(280, 128);
            this.lb_pedido_clientes.Name = "lb_pedido_clientes";
            this.lb_pedido_clientes.Size = new System.Drawing.Size(594, 307);
            this.lb_pedido_clientes.TabIndex = 0;
            this.lb_pedido_clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_pedido_clientes_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_ingresar_pedido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_pedido, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_buscar_cliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(280, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 119);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btn_ingresar_pedido
            // 
            this.btn_ingresar_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ingresar_pedido.Enabled = false;
            this.btn_ingresar_pedido.Location = new System.Drawing.Point(300, 62);
            this.btn_ingresar_pedido.Name = "btn_ingresar_pedido";
            this.btn_ingresar_pedido.Size = new System.Drawing.Size(291, 54);
            this.btn_ingresar_pedido.TabIndex = 3;
            this.btn_ingresar_pedido.Text = "Ingresar pedido";
            this.btn_ingresar_pedido.UseVisualStyleBackColor = true;
            this.btn_ingresar_pedido.Click += new System.EventHandler(this.btn_ingresar_pedido_Click);
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.Location = new System.Drawing.Point(3, 0);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(289, 25);
            this.lbl_pedido.TabIndex = 0;
            this.lbl_pedido.Text = "Ingrese el nombre del cliente";
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscar_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(300, 3);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(291, 53);
            this.btn_buscar_cliente.TabIndex = 1;
            this.btn_buscar_cliente.Text = "Buscar cliente";
            this.btn_buscar_cliente.UseVisualStyleBackColor = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cb_cliente, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_cliente, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 54);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // cb_cliente
            // 
            this.cb_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(3, 30);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(285, 24);
            this.cb_cliente.TabIndex = 4;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_cliente.Location = new System.Drawing.Point(3, 3);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(285, 22);
            this.tb_cliente.TabIndex = 4;
            // 
            // frm_menu_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_menu_pedidos";
            this.Text = "Menu pedidos";
            this.Load += new System.EventHandler(this.frm_menu_pedidos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_numero_personas.ResumeLayout(false);
            this.gb_numero_personas.PerformLayout();
            this.gb_menu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_despachar_orden;
        private System.Windows.Forms.GroupBox gb_numero_personas;
        private System.Windows.Forms.RadioButton rdb_4_persona;
        private System.Windows.Forms.RadioButton rdb_3_persona;
        private System.Windows.Forms.RadioButton rdb_2_persona;
        private System.Windows.Forms.RadioButton rdb_1_persona;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button btn_seleccionar_categoria;
        private System.Windows.Forms.ListBox lb_menu;
        private System.Windows.Forms.ComboBox cb_menu;
        private System.Windows.Forms.ListBox lb_pedido_clientes;
        private System.Windows.Forms.Button bt_cancelar_pedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_ingresar_pedido;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cb_cliente;
    }
}