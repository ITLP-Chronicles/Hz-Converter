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
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Frecuencia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 62);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Tiempo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 149);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Tiempo por Ciclo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 193);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Número de Ciclos";
            // 
            // txtFrecuencia
            // 
            txtFrecuencia.Location = new Point(88, 17);
            txtFrecuencia.Name = "txtFrecuencia";
            txtFrecuencia.Size = new Size(142, 23);
            txtFrecuencia.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(88, 59);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(142, 23);
            txtTiempo.TabIndex = 5;
            // 
            // txtTiempoPorCiclo
            // 
            txtTiempoPorCiclo.Location = new Point(123, 146);
            txtTiempoPorCiclo.Name = "txtTiempoPorCiclo";
            txtTiempoPorCiclo.ReadOnly = true;
            txtTiempoPorCiclo.Size = new Size(231, 23);
            txtTiempoPorCiclo.TabIndex = 6;
            // 
            // txtNumeroCiclos
            // 
            txtNumeroCiclos.Location = new Point(123, 190);
            txtNumeroCiclos.Name = "txtNumeroCiclos";
            txtNumeroCiclos.ReadOnly = true;
            txtNumeroCiclos.Size = new Size(231, 23);
            txtNumeroCiclos.TabIndex = 7;
            // 
            // cmbUnidad
            // 
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Items.AddRange(new object[] { "Hz", "kHZ", "MHz", "GHz" });
            cmbUnidad.Location = new Point(236, 17);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(121, 23);
            cmbUnidad.TabIndex = 8;
            // 
            // cmbTiempo
            // 
            cmbTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiempo.FormattingEnabled = true;
            cmbTiempo.Items.AddRange(new object[] { "Segundos", "Milisegundos", "Microsegundos", "Nanosegundos", "Picosegundos" });
            cmbTiempo.Location = new Point(236, 59);
            cmbTiempo.Name = "cmbTiempo";
            cmbTiempo.Size = new Size(121, 23);
            cmbTiempo.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(138, 106);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // TiempoCiclo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "TiempoCiclo";
            Size = new Size(368, 233);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFrecuencia;
        private TextBox txtTiempo;
        private TextBox txtTiempoPorCiclo;
        private TextBox txtNumeroCiclos;
        private ComboBox cmbUnidad;
        private ComboBox cmbTiempo;
        private Button btnCalcular;
    }
}
