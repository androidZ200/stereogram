namespace stereogram
{
    partial class FormDraw
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(57, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(846, 468);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(3, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(51, 32);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(3, 88);
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarThickness.Size = new System.Drawing.Size(45, 101);
            this.trackBarThickness.TabIndex = 2;
            this.trackBarThickness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarThickness.Value = 5;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll);
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Location = new System.Drawing.Point(3, 195);
            this.trackBarDepth.Maximum = 20;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarDepth.Size = new System.Drawing.Size(45, 101);
            this.trackBarDepth.TabIndex = 3;
            this.trackBarDepth.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDepth.Value = 20;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBarDepth_Scroll);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 50);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(51, 32);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(451, 344);
            this.Name = "FormDraw";
            this.Text = "FormDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.Button buttonClear;
    }
}