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
            SuspendLayout();
            // 
            // tiempoCiclo1
            // 
            tiempoCiclo1.Location = new Point(13, 42);
            tiempoCiclo1.Margin = new Padding(4, 5, 4, 5);
            tiempoCiclo1.Name = "tiempoCiclo1";
            tiempoCiclo1.Size = new Size(530, 372);
            tiempoCiclo1.TabIndex = 0;
            // 
            // frequencyGraph1
            // 
            frequencyGraph1.Frequency = 2F;
            frequencyGraph1.Location = new Point(601, 124);
            frequencyGraph1.Name = "frequencyGraph1";
            frequencyGraph1.PointsNum = 500;
            frequencyGraph1.Size = new Size(353, 225);
            frequencyGraph1.TabIndex = 1;
            frequencyGraph1.Time = 1F;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(frequencyGraph1);
            Controls.Add(tiempoCiclo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TiempoCiclo tiempoCiclo1;
        private FrequencyGraph frequencyGraph1;
    }
}
