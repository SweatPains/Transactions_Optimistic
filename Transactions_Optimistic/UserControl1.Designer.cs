namespace Transactions_Optimistic
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ReadData = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1001";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(87, 76);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(75, 23);
            this.ReadData.TabIndex = 2;
            this.ReadData.Text = "ReadData";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.Location = new System.Drawing.Point(87, 154);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(75, 23);
            this.UpdateData.TabIndex = 3;
            this.UpdateData.Text = "UpdateData";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(471, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.Button UpdateData;
    }
}
