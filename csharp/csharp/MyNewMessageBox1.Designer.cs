namespace csharp
{
    partial class MyNewMessageBox1
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
            this.buttonok1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugarea notei a fost realizata cu succes!";
            // 
            // buttonok1
            // 
            this.buttonok1.BackColor = System.Drawing.Color.Black;
            this.buttonok1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonok1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonok1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonok1.Location = new System.Drawing.Point(216, 47);
            this.buttonok1.Name = "buttonok1";
            this.buttonok1.Size = new System.Drawing.Size(88, 37);
            this.buttonok1.TabIndex = 1;
            this.buttonok1.Text = "OK";
            this.buttonok1.UseVisualStyleBackColor = false;
            this.buttonok1.Click += new System.EventHandler(this.buttonok1_Click);
            // 
            // MyNewMessageBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 110);
            this.Controls.Add(this.buttonok1);
            this.Controls.Add(this.label1);
            this.Name = "MyNewMessageBox1";
            this.Text = "MyNewMessageBox1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonok1;
    }
}