namespace HzConverter
{
    partial class SecondsComparatorDiv
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numberBox1 = new NumberBox();
            numberBox2 = new NumberBox();
            numberBox3 = new NumberBox();
            numberBox4 = new NumberBox();
            numberBox5 = new NumberBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Segundos (S)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Milisegundos (ms)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 109);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Microsegundos (μs)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 155);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 8;
            label4.Text = "Nanosegundos (ns)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 200);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 10;
            label5.Text = "Picosegundos (ps)";
            // 
            // numberBox1
            // 
            numberBox1.InnerText = "0";
            numberBox1.Location = new Point(140, 15);
            numberBox1.MinimumSize = new Size(0, 24);
            numberBox1.Name = "numberBox1";
            numberBox1.Size = new Size(159, 24);
            numberBox1.TabIndex = 12;
            numberBox1.Unit = SecondsComparator.SecondUnits.Second;
            // 
            // numberBox2
            // 
            numberBox2.InnerText = "0";
            numberBox2.Location = new Point(140, 55);
            numberBox2.MinimumSize = new Size(0, 24);
            numberBox2.Name = "numberBox2";
            numberBox2.Size = new Size(159, 24);
            numberBox2.TabIndex = 13;
            numberBox2.Unit = SecondsComparator.SecondUnits.Milisecond;
            // 
            // numberBox3
            // 
            numberBox3.InnerText = "0";
            numberBox3.Location = new Point(140, 100);
            numberBox3.MinimumSize = new Size(0, 24);
            numberBox3.Name = "numberBox3";
            numberBox3.Size = new Size(159, 24);
            numberBox3.TabIndex = 14;
            numberBox3.Unit = SecondsComparator.SecondUnits.Microsecond;
            // 
            // numberBox4
            // 
            numberBox4.InnerText = "0";
            numberBox4.Location = new Point(140, 146);
            numberBox4.MinimumSize = new Size(0, 24);
            numberBox4.Name = "numberBox4";
            numberBox4.Size = new Size(159, 24);
            numberBox4.TabIndex = 15;
            numberBox4.Unit = SecondsComparator.SecondUnits.Nanosecond;
            // 
            // numberBox5
            // 
            numberBox5.InnerText = "0";
            numberBox5.Location = new Point(140, 191);
            numberBox5.MinimumSize = new Size(0, 24);
            numberBox5.Name = "numberBox5";
            numberBox5.Size = new Size(159, 24);
            numberBox5.TabIndex = 16;
            numberBox5.Unit = SecondsComparator.SecondUnits.Picosecond;
            // 
            // DivComparator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numberBox5);
            Controls.Add(numberBox4);
            Controls.Add(numberBox3);
            Controls.Add(numberBox2);
            Controls.Add(numberBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DivComparator";
            Size = new Size(322, 237);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumberBox numberBox1;
        private NumberBox numberBox2;
        private NumberBox numberBox3;
        private NumberBox numberBox4;
        private NumberBox numberBox5;
    }
}
