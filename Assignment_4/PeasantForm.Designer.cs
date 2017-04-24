namespace Assignment_4
{
    partial class PeasantForm
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
            this.peasantOutput1 = new System.Windows.Forms.ListBox();
            this.peasantOutput2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peasantOutput1
            // 
            this.peasantOutput1.FormattingEnabled = true;
            this.peasantOutput1.ItemHeight = 20;
            this.peasantOutput1.Location = new System.Drawing.Point(55, 80);
            this.peasantOutput1.Name = "peasantOutput1";
            this.peasantOutput1.Size = new System.Drawing.Size(342, 644);
            this.peasantOutput1.TabIndex = 0;
            // 
            // peasantOutput2
            // 
            this.peasantOutput2.FormattingEnabled = true;
            this.peasantOutput2.ItemHeight = 20;
            this.peasantOutput2.Location = new System.Drawing.Point(475, 80);
            this.peasantOutput2.Name = "peasantOutput2";
            this.peasantOutput2.Size = new System.Drawing.Size(353, 644);
            this.peasantOutput2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulation waiting...";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("OCR A Std", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(331, 760);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 65);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 4;
            // 
            // PeasantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 863);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peasantOutput2);
            this.Controls.Add(this.peasantOutput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PeasantForm";
            this.Text = "Peasant Simulator 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peasantOutput1;
        private System.Windows.Forms.ListBox peasantOutput2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
    }
}