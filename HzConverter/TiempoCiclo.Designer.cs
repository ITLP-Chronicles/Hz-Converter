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
            txtTiempoPorCiclo = new TextBox();
            txtNumeroCiclos = new TextBox();
            cmbUnidad = new ComboBox();
            cmbTiempo = new ComboBox();
            btnCalcular = new Button();
            txtFrecuencia = new NumberBox();
            txtTiempo = new NumberBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Frecuencia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 82);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiempo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 198);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo por Ciclo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 258);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Número de Ciclos";
            // 
            // txtTiempoPorCiclo
            // 
            txtTiempoPorCiclo.Location = new Point(141, 194);
            txtTiempoPorCiclo.Margin = new Padding(3, 4, 3, 4);
            txtTiempoPorCiclo.Name = "txtTiempoPorCiclo";
            txtTiempoPorCiclo.ReadOnly = true;
            txtTiempoPorCiclo.Size = new Size(263, 27);
            txtTiempoPorCiclo.TabIndex = 6;
            // 
            // txtNumeroCiclos
            // 
            txtNumeroCiclos.Location = new Point(141, 254);
            txtNumeroCiclos.Margin = new Padding(3, 4, 3, 4);
            txtNumeroCiclos.Name = "txtNumeroCiclos";
            txtNumeroCiclos.ReadOnly = true;
            txtNumeroCiclos.Size = new Size(263, 27);
            txtNumeroCiclos.TabIndex = 7;
            // 
            // cmbUnidad
            // 
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Items.AddRange(new object[] { "Hz", "KHz", "MHz", "GHz" });
            cmbUnidad.Location = new Point(286, 18);
            cmbUnidad.Margin = new Padding(3, 4, 3, 4);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(138, 28);
            cmbUnidad.TabIndex = 8;
            // 
            // cmbTiempo
            // 
            cmbTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiempo.FormattingEnabled = true;
            cmbTiempo.Items.AddRange(new object[] { "Segundos", "Milisegundos", "Microsegundos", "Nanosegundos", "Picosegundos" });
            cmbTiempo.Location = new Point(286, 77);
            cmbTiempo.Margin = new Padding(3, 4, 3, 4);
            cmbTiempo.Name = "cmbTiempo";
            cmbTiempo.Size = new Size(138, 28);
            cmbTiempo.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(158, 142);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 30);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtFrecuencia
            // 
            txtFrecuencia.InnerText = "0";
            txtFrecuencia.Location = new Point(101, 22);
            txtFrecuencia.Margin = new Padding(3, 4, 3, 4);
            txtFrecuencia.MinimumSize = new Size(0, 32);
            txtFrecuencia.Name = "txtFrecuencia";
            txtFrecuencia.Size = new Size(179, 40);
            txtFrecuencia.TabIndex = 11;
            // 
            // txtTiempo
            // 
            txtTiempo.InnerText = "0";
            txtTiempo.Location = new Point(101, 77);
            txtTiempo.Margin = new Padding(3, 4, 3, 4);
            txtTiempo.MinimumSize = new Size(0, 32);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(179, 40);
            txtTiempo.TabIndex = 12;
            // 
            // TiempoCiclo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTiempo);
            Controls.Add(txtFrecuencia);
            Controls.Add(btnCalcular);
            Controls.Add(cmbTiempo);
            Controls.Add(cmbUnidad);
            Controls.Add(txtNumeroCiclos);
            Controls.Add(txtTiempoPorCiclo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TiempoCiclo";
            Size = new Size(459, 310);
            Load += TiempoCiclo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTiempoPorCiclo;
        private TextBox txtNumeroCiclos;
        private ComboBox cmbUnidad;
        private ComboBox cmbTiempo;
        public Button btnCalcular;
        private NumberBox txtFrecuencia;
        private NumberBox txtTiempo;
    }
}
