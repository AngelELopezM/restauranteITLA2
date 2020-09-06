namespace restauranteITLA_2
{
    partial class frm_menu_principal
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_mesa4 = new System.Windows.Forms.Button();
            this.btn_mesa3 = new System.Windows.Forms.Button();
            this.btn_mesa2 = new System.Windows.Forms.Button();
            this.btn_mesa1 = new System.Windows.Forms.Button();
            this.lblestado_mesa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_limpiar_mesa = new System.Windows.Forms.Button();
            this.btn_reanudar_orden = new System.Windows.Forms.Button();
            this.btn_nueva_orden = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.27962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.72038F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblestado_mesa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_salir, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_mesa4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_mesa3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_mesa2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_mesa1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 390);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_mesa4
            // 
            this.btn_mesa4.BackColor = System.Drawing.Color.Green;
            this.btn_mesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mesa4.Location = new System.Drawing.Point(312, 198);
            this.btn_mesa4.Name = "btn_mesa4";
            this.btn_mesa4.Size = new System.Drawing.Size(304, 189);
            this.btn_mesa4.TabIndex = 3;
            this.btn_mesa4.Text = "Mesa #4";
            this.btn_mesa4.UseVisualStyleBackColor = false;
            this.btn_mesa4.Click += new System.EventHandler(this.btn_mesa4_Click);
            // 
            // btn_mesa3
            // 
            this.btn_mesa3.BackColor = System.Drawing.Color.Green;
            this.btn_mesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mesa3.Location = new System.Drawing.Point(3, 198);
            this.btn_mesa3.Name = "btn_mesa3";
            this.btn_mesa3.Size = new System.Drawing.Size(303, 189);
            this.btn_mesa3.TabIndex = 2;
            this.btn_mesa3.Text = "Mesa #3";
            this.btn_mesa3.UseVisualStyleBackColor = false;
            this.btn_mesa3.Click += new System.EventHandler(this.btn_mesa3_Click);
            // 
            // btn_mesa2
            // 
            this.btn_mesa2.BackColor = System.Drawing.Color.Green;
            this.btn_mesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mesa2.Location = new System.Drawing.Point(312, 3);
            this.btn_mesa2.Name = "btn_mesa2";
            this.btn_mesa2.Size = new System.Drawing.Size(304, 189);
            this.btn_mesa2.TabIndex = 1;
            this.btn_mesa2.Text = "Mesa #2";
            this.btn_mesa2.UseVisualStyleBackColor = false;
            this.btn_mesa2.Click += new System.EventHandler(this.btn_mesa2_Click);
            // 
            // btn_mesa1
            // 
            this.btn_mesa1.BackColor = System.Drawing.Color.Green;
            this.btn_mesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mesa1.Location = new System.Drawing.Point(3, 3);
            this.btn_mesa1.Name = "btn_mesa1";
            this.btn_mesa1.Size = new System.Drawing.Size(303, 189);
            this.btn_mesa1.TabIndex = 0;
            this.btn_mesa1.Text = "Mesa #1";
            this.btn_mesa1.UseVisualStyleBackColor = false;
            this.btn_mesa1.Click += new System.EventHandler(this.btn_mesa1_Click);
            // 
            // lblestado_mesa
            // 
            this.lblestado_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblestado_mesa.AutoSize = true;
            this.lblestado_mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado_mesa.Location = new System.Drawing.Point(3, 411);
            this.lblestado_mesa.Name = "lblestado_mesa";
            this.lblestado_mesa.Size = new System.Drawing.Size(189, 24);
            this.lblestado_mesa.TabIndex = 2;
            this.lblestado_mesa.Text = "Estado de la mesa";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(198, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_limpiar_mesa, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_reanudar_orden, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_nueva_orden, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(628, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 390);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btn_limpiar_mesa
            // 
            this.btn_limpiar_mesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_limpiar_mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_mesa.Location = new System.Drawing.Point(3, 265);
            this.btn_limpiar_mesa.Name = "btn_limpiar_mesa";
            this.btn_limpiar_mesa.Size = new System.Drawing.Size(163, 122);
            this.btn_limpiar_mesa.TabIndex = 2;
            this.btn_limpiar_mesa.Text = "Limpiar mesa";
            this.btn_limpiar_mesa.UseVisualStyleBackColor = true;
            this.btn_limpiar_mesa.Click += new System.EventHandler(this.btn_limpiar_mesa_Click);
            // 
            // btn_reanudar_orden
            // 
            this.btn_reanudar_orden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reanudar_orden.Enabled = false;
            this.btn_reanudar_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reanudar_orden.Location = new System.Drawing.Point(3, 134);
            this.btn_reanudar_orden.Name = "btn_reanudar_orden";
            this.btn_reanudar_orden.Size = new System.Drawing.Size(163, 125);
            this.btn_reanudar_orden.TabIndex = 1;
            this.btn_reanudar_orden.Text = "Reanudar orden";
            this.btn_reanudar_orden.UseVisualStyleBackColor = true;
            this.btn_reanudar_orden.Click += new System.EventHandler(this.btn_reanudar_orden_Click);
            // 
            // btn_nueva_orden
            // 
            this.btn_nueva_orden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nueva_orden.Enabled = false;
            this.btn_nueva_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_orden.Location = new System.Drawing.Point(3, 3);
            this.btn_nueva_orden.Name = "btn_nueva_orden";
            this.btn_nueva_orden.Size = new System.Drawing.Size(163, 125);
            this.btn_nueva_orden.TabIndex = 0;
            this.btn_nueva_orden.Text = "Nueva orden";
            this.btn_nueva_orden.UseVisualStyleBackColor = true;
            this.btn_nueva_orden.Click += new System.EventHandler(this.btn_nueva_orden_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(628, 399);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(169, 48);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // frm_menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_menu_principal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.frm_menu_principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_mesa4;
        private System.Windows.Forms.Button btn_mesa3;
        private System.Windows.Forms.Button btn_mesa2;
        private System.Windows.Forms.Button btn_mesa1;
        private System.Windows.Forms.Label lblestado_mesa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_limpiar_mesa;
        private System.Windows.Forms.Button btn_reanudar_orden;
        private System.Windows.Forms.Button btn_nueva_orden;
        private System.Windows.Forms.Button btn_salir;
    }
}

