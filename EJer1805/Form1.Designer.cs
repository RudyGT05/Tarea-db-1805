namespace EJer1805
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelpoder = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.tbcrear = new System.Windows.Forms.Button();
            this.numericUpDownpoder = new System.Windows.Forms.NumericUpDown();
            this.comboBoxraza = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.labelraza = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.textBoxhistoria = new System.Windows.Forms.TextBox();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelhsistoria = new System.Windows.Forms.Label();
            this.dateTimePickercreacion = new System.Windows.Forms.DateTimePicker();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoder)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Probar Conexion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(512, 203);
            this.dataGridViewPersonajes.TabIndex = 2;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(129, 289);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(97, 50);
            this.cargar.TabIndex = 3;
            this.cargar.Text = "Cargar Datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(544, 9);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 4;
            this.labelid.Text = "ID";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(544, 59);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(44, 13);
            this.labelnombre.TabIndex = 5;
            this.labelnombre.Text = "Nombre";
            // 
            // labelpoder
            // 
            this.labelpoder.AutoSize = true;
            this.labelpoder.Location = new System.Drawing.Point(544, 166);
            this.labelpoder.Name = "labelpoder";
            this.labelpoder.Size = new System.Drawing.Size(62, 13);
            this.labelpoder.TabIndex = 6;
            this.labelpoder.Text = "Nivel Poder";
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(608, 9);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(107, 20);
            this.id1.TabIndex = 7;
            this.id1.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id1.Leave += new System.EventHandler(this.id_Leave);
            // 
            // tbcrear
            // 
            this.tbcrear.Location = new System.Drawing.Point(704, 289);
            this.tbcrear.Name = "tbcrear";
            this.tbcrear.Size = new System.Drawing.Size(97, 50);
            this.tbcrear.TabIndex = 10;
            this.tbcrear.Text = "Crear";
            this.tbcrear.UseVisualStyleBackColor = true;
            this.tbcrear.Click += new System.EventHandler(this.tbcrear_Click);
            // 
            // numericUpDownpoder
            // 
            this.numericUpDownpoder.Location = new System.Drawing.Point(608, 159);
            this.numericUpDownpoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownpoder.Name = "numericUpDownpoder";
            this.numericUpDownpoder.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownpoder.TabIndex = 11;
            // 
            // comboBoxraza
            // 
            this.comboBoxraza.FormattingEnabled = true;
            this.comboBoxraza.Location = new System.Drawing.Point(608, 114);
            this.comboBoxraza.Name = "comboBoxraza";
            this.comboBoxraza.Size = new System.Drawing.Size(108, 21);
            this.comboBoxraza.TabIndex = 12;
            this.comboBoxraza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(232, 289);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(97, 50);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // labelraza
            // 
            this.labelraza.AutoSize = true;
            this.labelraza.Location = new System.Drawing.Point(544, 114);
            this.labelraza.Name = "labelraza";
            this.labelraza.Size = new System.Drawing.Size(32, 13);
            this.labelraza.TabIndex = 14;
            this.labelraza.Text = "Raza";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(609, 56);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(107, 20);
            this.tbnombre.TabIndex = 16;
            // 
            // textBoxhistoria
            // 
            this.textBoxhistoria.Location = new System.Drawing.Point(609, 244);
            this.textBoxhistoria.Name = "textBoxhistoria";
            this.textBoxhistoria.Size = new System.Drawing.Size(107, 20);
            this.textBoxhistoria.TabIndex = 18;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Location = new System.Drawing.Point(544, 203);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(37, 13);
            this.labelfecha.TabIndex = 19;
            this.labelfecha.Text = "Fecha";
            // 
            // labelhsistoria
            // 
            this.labelhsistoria.AutoSize = true;
            this.labelhsistoria.Location = new System.Drawing.Point(544, 247);
            this.labelhsistoria.Name = "labelhsistoria";
            this.labelhsistoria.Size = new System.Drawing.Size(42, 13);
            this.labelhsistoria.TabIndex = 20;
            this.labelhsistoria.Text = "Historia";
            // 
            // dateTimePickercreacion
            // 
            this.dateTimePickercreacion.Location = new System.Drawing.Point(601, 196);
            this.dateTimePickercreacion.Name = "dateTimePickercreacion";
            this.dateTimePickercreacion.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickercreacion.TabIndex = 21;
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(601, 289);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(97, 50);
            this.btactualizar.TabIndex = 22;
            this.btactualizar.Text = "Actualizar Datos";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(498, 289);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(97, 50);
            this.btdelete.TabIndex = 23;
            this.btdelete.Text = "Eliminar ";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.dateTimePickercreacion);
            this.Controls.Add(this.labelhsistoria);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.textBoxhistoria);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.labelraza);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.comboBoxraza);
            this.Controls.Add(this.numericUpDownpoder);
            this.Controls.Add(this.tbcrear);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.labelpoder);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelpoder;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.Button tbcrear;
        private System.Windows.Forms.NumericUpDown numericUpDownpoder;
        private System.Windows.Forms.ComboBox comboBoxraza;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label labelraza;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox textBoxhistoria;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label labelhsistoria;
        private System.Windows.Forms.DateTimePicker dateTimePickercreacion;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btdelete;
    }
}

