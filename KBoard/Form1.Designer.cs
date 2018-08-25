namespace KBoard
{
    partial class Form1
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
            this.Submit = new System.Windows.Forms.Button();
            this.InBx = new System.Windows.Forms.TextBox();
            this.Dwell_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(155, 331);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(200, 36);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InBx
            // 
            this.InBx.Location = new System.Drawing.Point(9, 243);
            this.InBx.Name = "InBx";
            this.InBx.Size = new System.Drawing.Size(498, 22);
            this.InBx.TabIndex = 1;
            this.InBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InBx_KeyDown);
            this.InBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InBx_KeyPress);
            this.InBx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InBx_KeyUp);
            // 
            // Dwell_time
            // 
            this.Dwell_time.AcceptsReturn = true;
            this.Dwell_time.Location = new System.Drawing.Point(267, 165);
            this.Dwell_time.Name = "Dwell_time";
            this.Dwell_time.ReadOnly = true;
            this.Dwell_time.Size = new System.Drawing.Size(196, 22);
            this.Dwell_time.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 469);
            this.Controls.Add(this.Dwell_time);
            this.Controls.Add(this.InBx);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "KBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox InBx;
        private System.Windows.Forms.TextBox Dwell_time;
    }
}

