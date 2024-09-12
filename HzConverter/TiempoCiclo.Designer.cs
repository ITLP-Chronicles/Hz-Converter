namespace HzConverter
{
    partial class TiempoCiclo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFrecuencia = new TextBox();
            txtTiempo = new TextBox();
            txtTiempoPorCiclo = new TextBox();
            txtNumeroCiclos = new TextBox();
            cmbUnidad = new ComboBox();
            cmbTiempo = new ComboBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Frecuencia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Tiempo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 248);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 2;
            label3.Text = "Tiempo por Ciclo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 322);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 3;
            label4.Text = "Número de Ciclos";
            // 
            // txtFrecuencia
            // 
            txtFrecuencia.Location = new Point(126, 28);
            txtFrecuencia.Margin = new Padding(4, 5, 4, 5);
            txtFrecuencia.Name = "txtFrecuencia";
            txtFrecuencia.Size = new Size(201, 31);
            txtFrecuencia.TabIndex = 4;
            txtFrecuencia.TextChanged += txtFrecuencia_TextChanged;
            txtFrecuencia.KeyPress += txtFrecuencia_KeyPress;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(126, 98);
            txtTiempo.Margin = new Padding(4, 5, 4, 5);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(201, 31);
            txtTiempo.TabIndex = 5;
            txtTiempo.TextChanged += txtTiempo_TextChanged;
            txtTiempo.KeyPress += txtTiempo_KeyPress;
            // 
            // txtTiempoPorCiclo
            // 
            txtTiempoPorCiclo.Location = new Point(176, 243);
            txtTiempoPorCiclo.Margin = new Padding(4, 5, 4, 5);
            txtTiempoPorCiclo.Name = "txtTiempoPorCiclo";
            txtTiempoPorCiclo.ReadOnly = true;
            txtTiempoPorCiclo.Size = new Size(328, 31);
            txtTiempoPorCiclo.TabIndex = 6;
            // 
            // txtNumeroCiclos
            // 
            txtNumeroCiclos.Location = new Point(176, 317);
            txtNumeroCiclos.Margin = new Padding(4, 5, 4, 5);
            txtNumeroCiclos.Name = "txtNumeroCiclos";
            txtNumeroCiclos.ReadOnly = true;
            txtNumeroCiclos.Size = new Size(328, 31);
            txtNumeroCiclos.TabIndex = 7;
            // 
            // cmbUnidad
            // 
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Items.AddRange(new object[] { "Hz", "KHz", "MHz", "GHz" });
            cmbUnidad.Location = new Point(337, 28);
            cmbUnidad.Margin = new Padding(4, 5, 4, 5);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(171, 33);
            cmbUnidad.TabIndex = 8;
            // 
            // cmbTiempo
            // 
            cmbTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiempo.FormattingEnabled = true;
            cmbTiempo.Items.AddRange(new object[] { "Segundos", "Milisegundos", "Microsegundos", "Nanosegundos", "Picosegundos" });
            cmbTiempo.Location = new Point(337, 98);
            cmbTiempo.Margin = new Padding(4, 5, 4, 5);
            cmbTiempo.Name = "cmbTiempo";
            cmbTiempo.Size = new Size(171, 33);
            cmbTiempo.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(197, 177);
            btnCalcular.Margin = new Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 38);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // TiempoCiclo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCalcular);
            Controls.Add(cmbTiempo);
            Controls.Add(cmbUnidad);
            Controls.Add(txtNumeroCiclos);
            Controls.Add(txtTiempoPorCiclo);
            Controls.Add(txtTiempo);
            Controls.Add(txtFrecuencia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TiempoCiclo";
            Size = new Size(526, 388);
            Load += TiempoCiclo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTiempo;
        private TextBox txtTiempoPorCiclo;
        private TextBox txtNumeroCiclos;
        private ComboBox cmbUnidad;
        private ComboBox cmbTiempo;
        public Button btnCalcular;
        public TextBox txtFrecuencia;
    }
}
