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
            tiempoCiclo1.Location = new Point(21, 267);
            tiempoCiclo1.Name = "tiempoCiclo1";
            tiempoCiclo1.Size = new Size(371, 224);
            tiempoCiclo1.TabIndex = 0;
            // 
            // frequencyGraph1
            // 
            frequencyGraph1.Color = Color.LimeGreen;
            frequencyGraph1.Frequency = 2F;
            frequencyGraph1.Location = new Point(207, 60);
            frequencyGraph1.Margin = new Padding(2);
            frequencyGraph1.Name = "frequencyGraph1";
            frequencyGraph1.PointsNum = 500;
            frequencyGraph1.Size = new Size(306, 194);
            frequencyGraph1.TabIndex = 1;
            frequencyGraph1.Time = 1F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(398, 25);
            label1.TabIndex = 2;
            label1.Text = "Convertidor frecuencia a tiempo por ciclo";
            // 
            // secondsComparatorDiv1
            // 
            secondsComparatorDiv1.Location = new Point(391, 267);
            secondsComparatorDiv1.Name = "secondsComparatorDiv1";
            secondsComparatorDiv1.Size = new Size(321, 235);
            secondsComparatorDiv1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 500);
            Controls.Add(secondsComparatorDiv1);
            Controls.Add(label1);
            Controls.Add(frequencyGraph1);
            Controls.Add(tiempoCiclo1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
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
