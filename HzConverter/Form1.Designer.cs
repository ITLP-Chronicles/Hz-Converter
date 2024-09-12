namespace HzConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tiempoCiclo1 = new TiempoCiclo();
            frequencyGraph1 = new FrequencyGraph();
            label1 = new Label();
            secondsComparatorDiv1 = new SecondsComparatorDiv();
            SuspendLayout();
            // 
            // tiempoCiclo1
            // 
            tiempoCiclo1.Frequency = 1F;
            tiempoCiclo1.Location = new Point(24, 356);
            tiempoCiclo1.Margin = new Padding(3, 4, 3, 4);
            tiempoCiclo1.Name = "tiempoCiclo1";
            tiempoCiclo1.Size = new Size(424, 298);
            tiempoCiclo1.TabIndex = 0;
            // 
            // frequencyGraph1
            // 
            frequencyGraph1.Color = Color.LimeGreen;
            frequencyGraph1.Frequency = 2F;
            frequencyGraph1.Location = new Point(237, 80);
            frequencyGraph1.Margin = new Padding(2, 2, 2, 2);
            frequencyGraph1.Name = "frequencyGraph1";
            frequencyGraph1.PointsNum = 500;
            frequencyGraph1.Size = new Size(350, 259);
            frequencyGraph1.TabIndex = 1;
            frequencyGraph1.Time = 1F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(497, 32);
            label1.TabIndex = 2;
            label1.Text = "Convertidor frecuencia a tiempo por ciclo";
            // 
            // secondsComparatorDiv1
            // 
            secondsComparatorDiv1.Location = new Point(454, 356);
            secondsComparatorDiv1.Margin = new Padding(3, 4, 3, 4);
            secondsComparatorDiv1.Name = "secondsComparatorDiv1";
            secondsComparatorDiv1.Size = new Size(367, 313);
            secondsComparatorDiv1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 667);
            Controls.Add(secondsComparatorDiv1);
            Controls.Add(label1);
            Controls.Add(frequencyGraph1);
            Controls.Add(tiempoCiclo1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertidor Hz a s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TiempoCiclo tiempoCiclo1;
        private FrequencyGraph frequencyGraph1;
        private Label label1;
        private SecondsComparatorDiv secondsComparatorDiv1;
    }
}
