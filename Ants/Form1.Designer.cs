namespace Ants
{
    partial class frm_Output
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
            this.pct_Output = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Output
            // 
            this.pct_Output.Location = new System.Drawing.Point(12, 12);
            this.pct_Output.Name = "pct_Output";
            this.pct_Output.Size = new System.Drawing.Size(268, 249);
            this.pct_Output.TabIndex = 0;
            this.pct_Output.TabStop = false;
            this.pct_Output.Click += new System.EventHandler(this.pct_Output_Click);
            // 
            // frm_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.pct_Output);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frm_Output";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Langtons Ants";
            this.Load += new System.EventHandler(this.frm_Output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_Output;
    }
}

