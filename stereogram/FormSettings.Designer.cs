namespace stereogram
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxW = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxH = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // maskedTextBoxW
            // 
            this.maskedTextBoxW.Location = new System.Drawing.Point(54, 10);
            this.maskedTextBoxW.Mask = "000000";
            this.maskedTextBoxW.Name = "maskedTextBoxW";
            this.maskedTextBoxW.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxW.TabIndex = 1;
            // 
            // maskedTextBoxH
            // 
            this.maskedTextBoxH.Location = new System.Drawing.Point(54, 36);
            this.maskedTextBoxH.Mask = "000000";
            this.maskedTextBoxH.Name = "maskedTextBoxH";
            this.maskedTextBoxH.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // maskedTextBoxC
            // 
            this.maskedTextBoxC.Location = new System.Drawing.Point(54, 62);
            this.maskedTextBoxC.Mask = "000000";
            this.maskedTextBoxC.Name = "maskedTextBoxC";
            this.maskedTextBoxC.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cycle";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 90);
            this.Controls.Add(this.maskedTextBoxC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxW);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxW;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxC;
        private System.Windows.Forms.Label label3;
    }
}