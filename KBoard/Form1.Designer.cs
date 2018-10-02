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
            this.Heading = new System.Windows.Forms.Label();
            this.SubH = new System.Windows.Forms.Label();
            this.PreLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoOpenExcel = new System.Windows.Forms.CheckBox();
            this.ReOpen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(146, 289);
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
            this.Dwell_time.Location = new System.Drawing.Point(271, 168);
            this.Dwell_time.Name = "Dwell_time";
            this.Dwell_time.ReadOnly = true;
            this.Dwell_time.Size = new System.Drawing.Size(196, 22);
            this.Dwell_time.TabIndex = 2;
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Heading.Location = new System.Drawing.Point(-9, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(527, 64);
            this.Heading.TabIndex = 3;
            this.Heading.Text = "KBoard";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubH
            // 
            this.SubH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SubH.Location = new System.Drawing.Point(3, 73);
            this.SubH.Name = "SubH";
            this.SubH.Size = new System.Drawing.Size(504, 25);
            this.SubH.TabIndex = 4;
            this.SubH.Text = "Key to your security";
            this.SubH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreLetter
            // 
            this.PreLetter.Location = new System.Drawing.Point(178, 168);
            this.PreLetter.Name = "PreLetter";
            this.PreLetter.ReadOnly = true;
            this.PreLetter.Size = new System.Drawing.Size(59, 22);
            this.PreLetter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dwell time of  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "is";
            // 
            // DoOpenExcel
            // 
            this.DoOpenExcel.AutoSize = true;
            this.DoOpenExcel.Checked = true;
            this.DoOpenExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoOpenExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoOpenExcel.Location = new System.Drawing.Point(26, 363);
            this.DoOpenExcel.Name = "DoOpenExcel";
            this.DoOpenExcel.Size = new System.Drawing.Size(277, 24);
            this.DoOpenExcel.TabIndex = 8;
            this.DoOpenExcel.Text = "View Data Captured after Submit";
            this.DoOpenExcel.UseVisualStyleBackColor = true;
            // 
            // ReOpen
            // 
            this.ReOpen.AutoSize = true;
            this.ReOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReOpen.Location = new System.Drawing.Point(29, 397);
            this.ReOpen.Name = "ReOpen";
            this.ReOpen.Size = new System.Drawing.Size(196, 24);
            this.ReOpen.TabIndex = 9;
            this.ReOpen.Text = "Re-Open After Submit";
            this.ReOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 469);
            this.Controls.Add(this.ReOpen);
            this.Controls.Add(this.DoOpenExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreLetter);
            this.Controls.Add(this.SubH);
            this.Controls.Add(this.Heading);
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
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label SubH;
        private System.Windows.Forms.TextBox PreLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DoOpenExcel;
        private System.Windows.Forms.CheckBox ReOpen;
    }
}

