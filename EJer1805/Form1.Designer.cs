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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.tbcrear = new System.Windows.Forms.Button();
            this.numericUpDownpoder = new System.Windows.Forms.NumericUpDown();
            this.comboBoxraza = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoder)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 40);
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
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(315, 179);
            this.dataGridViewPersonajes.TabIndex = 2;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(352, 200);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(97, 50);
            this.cargar.TabIndex = 3;
            this.cargar.Text = "Cargar Datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(608, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(107, 20);
            this.id.TabIndex = 7;
            this.id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // tbcrear
            // 
            this.tbcrear.Location = new System.Drawing.Point(608, 218);
            this.tbcrear.Name = "tbcrear";
            this.tbcrear.Size = new System.Drawing.Size(97, 50);
            this.tbcrear.TabIndex = 10;
            this.tbcrear.Text = "Crear";
            this.tbcrear.UseVisualStyleBackColor = true;
            this.tbcrear.Click += new System.EventHandler(this.tbcrear_Click);
            // 
            // numericUpDownpoder
            // 
            this.numericUpDownpoder.Location = new System.Drawing.Point(608, 179);
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
            this.comboBoxraza.Location = new System.Drawing.Point(595, 108);
            this.comboBoxraza.Name = "comboBoxraza";
            this.comboBoxraza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxraza.TabIndex = 12;
            this.comboBoxraza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(432, 289);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(97, 50);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.comboBoxraza);
            this.Controls.Add(this.numericUpDownpoder);
            this.Controls.Add(this.tbcrear);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button tbcrear;
        private System.Windows.Forms.NumericUpDown numericUpDownpoder;
        private System.Windows.Forms.ComboBox comboBoxraza;
        private System.Windows.Forms.Button btnbuscar;
    }
}

