namespace Particulas
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
            this.components = new System.ComponentModel.Container();
            this.PICTURE_BOX = new System.Windows.Forms.PictureBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // PICTURE_BOX
            // 
            this.PICTURE_BOX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PICTURE_BOX.Location = new System.Drawing.Point(8, 7);
            this.PICTURE_BOX.Margin = new System.Windows.Forms.Padding(100, 100, 0, 0);
            this.PICTURE_BOX.Name = "PICTURE_BOX";
            this.PICTURE_BOX.Size = new System.Drawing.Size(867, 545);
            this.PICTURE_BOX.TabIndex = 0;
            this.PICTURE_BOX.TabStop = false;
            this.PICTURE_BOX.Click += new System.EventHandler(this.PICTURE_BOX_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PICTURE_BOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PICTURE_BOX;
        private System.Windows.Forms.Timer TIMER;
    }
}