namespace csharp
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
            this.textBoxNumeInregistrare = new System.Windows.Forms.TextBox();
            this.labelInregistrare = new System.Windows.Forms.Label();
            this.labelNumeInregistrare = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxParolaInregistrare = new System.Windows.Forms.TextBox();
            this.labelConectare = new System.Windows.Forms.Label();
            this.labelNumeConectare = new System.Windows.Forms.Label();
            this.labelParolaConectare = new System.Windows.Forms.Label();
            this.textBoxNumeConectare = new System.Windows.Forms.TextBox();
            this.textBoxParolaConectare = new System.Windows.Forms.TextBox();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonConectare = new System.Windows.Forms.Button();
            this.panelINREGISTRARE = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelINREGISTRARE.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeInregistrare
            // 
            this.textBoxNumeInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxNumeInregistrare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeInregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxNumeInregistrare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeInregistrare.Location = new System.Drawing.Point(79, 45);
            this.textBoxNumeInregistrare.Name = "textBoxNumeInregistrare";
            this.textBoxNumeInregistrare.Size = new System.Drawing.Size(122, 21);
            this.textBoxNumeInregistrare.TabIndex = 0;
            this.textBoxNumeInregistrare.TextChanged += new System.EventHandler(this.textBoxNumeInregistrare_TextChanged);
            // 
            // labelInregistrare
            // 
            this.labelInregistrare.AutoSize = true;
            this.labelInregistrare.BackColor = System.Drawing.Color.Transparent;
            this.labelInregistrare.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInregistrare.Location = new System.Drawing.Point(13, 3);
            this.labelInregistrare.Name = "labelInregistrare";
            this.labelInregistrare.Size = new System.Drawing.Size(188, 31);
            this.labelInregistrare.TabIndex = 1;
            this.labelInregistrare.Text = "Inregistrare";
            // 
            // labelNumeInregistrare
            // 
            this.labelNumeInregistrare.AutoSize = true;
            this.labelNumeInregistrare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeInregistrare.Location = new System.Drawing.Point(15, 45);
            this.labelNumeInregistrare.Name = "labelNumeInregistrare";
            this.labelNumeInregistrare.Size = new System.Drawing.Size(61, 21);
            this.labelNumeInregistrare.TabIndex = 2;
            this.labelNumeInregistrare.Text = "Nume:";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.Location = new System.Drawing.Point(15, 83);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(63, 21);
            this.labelParola.TabIndex = 3;
            this.labelParola.Text = "Parola:";
            // 
            // textBoxParolaInregistrare
            // 
            this.textBoxParolaInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxParolaInregistrare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxParolaInregistrare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParolaInregistrare.Location = new System.Drawing.Point(79, 84);
            this.textBoxParolaInregistrare.Name = "textBoxParolaInregistrare";
            this.textBoxParolaInregistrare.PasswordChar = '*';
            this.textBoxParolaInregistrare.Size = new System.Drawing.Size(122, 21);
            this.textBoxParolaInregistrare.TabIndex = 4;
            // 
            // labelConectare
            // 
            this.labelConectare.AutoSize = true;
            this.labelConectare.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConectare.Location = new System.Drawing.Point(29, 3);
            this.labelConectare.Name = "labelConectare";
            this.labelConectare.Size = new System.Drawing.Size(161, 31);
            this.labelConectare.TabIndex = 5;
            this.labelConectare.Text = "Conectare";
            // 
            // labelNumeConectare
            // 
            this.labelNumeConectare.AutoSize = true;
            this.labelNumeConectare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeConectare.Location = new System.Drawing.Point(17, 45);
            this.labelNumeConectare.Name = "labelNumeConectare";
            this.labelNumeConectare.Size = new System.Drawing.Size(61, 21);
            this.labelNumeConectare.TabIndex = 6;
            this.labelNumeConectare.Text = "Nume:";
            // 
            // labelParolaConectare
            // 
            this.labelParolaConectare.AutoSize = true;
            this.labelParolaConectare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParolaConectare.Location = new System.Drawing.Point(17, 83);
            this.labelParolaConectare.Name = "labelParolaConectare";
            this.labelParolaConectare.Size = new System.Drawing.Size(63, 21);
            this.labelParolaConectare.TabIndex = 7;
            this.labelParolaConectare.Text = "Parola:";
            // 
            // textBoxNumeConectare
            // 
            this.textBoxNumeConectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxNumeConectare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeConectare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeConectare.Location = new System.Drawing.Point(84, 48);
            this.textBoxNumeConectare.Name = "textBoxNumeConectare";
            this.textBoxNumeConectare.Size = new System.Drawing.Size(121, 21);
            this.textBoxNumeConectare.TabIndex = 8;
            // 
            // textBoxParolaConectare
            // 
            this.textBoxParolaConectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxParolaConectare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxParolaConectare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParolaConectare.Location = new System.Drawing.Point(84, 86);
            this.textBoxParolaConectare.Name = "textBoxParolaConectare";
            this.textBoxParolaConectare.PasswordChar = '*';
            this.textBoxParolaConectare.Size = new System.Drawing.Size(121, 21);
            this.textBoxParolaConectare.TabIndex = 9;
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.BackColor = System.Drawing.Color.Black;
            this.buttonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInregistrare.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInregistrare.Location = new System.Drawing.Point(15, 125);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(186, 35);
            this.buttonInregistrare.TabIndex = 10;
            this.buttonInregistrare.Text = "Inregistreaza-te!";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // buttonConectare
            // 
            this.buttonConectare.BackColor = System.Drawing.Color.Black;
            this.buttonConectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectare.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectare.ForeColor = System.Drawing.Color.White;
            this.buttonConectare.Location = new System.Drawing.Point(21, 125);
            this.buttonConectare.Name = "buttonConectare";
            this.buttonConectare.Size = new System.Drawing.Size(184, 35);
            this.buttonConectare.TabIndex = 11;
            this.buttonConectare.Text = "Conecteaza-te!";
            this.buttonConectare.UseVisualStyleBackColor = false;
            this.buttonConectare.Click += new System.EventHandler(this.buttonConectare_Click);
            // 
            // panelINREGISTRARE
            // 
            this.panelINREGISTRARE.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelINREGISTRARE.Controls.Add(this.flowLayoutPanel1);
            this.panelINREGISTRARE.Controls.Add(this.labelInregistrare);
            this.panelINREGISTRARE.Controls.Add(this.buttonInregistrare);
            this.panelINREGISTRARE.Controls.Add(this.labelNumeInregistrare);
            this.panelINREGISTRARE.Controls.Add(this.textBoxNumeInregistrare);
            this.panelINREGISTRARE.Controls.Add(this.labelParola);
            this.panelINREGISTRARE.Controls.Add(this.textBoxParolaInregistrare);
            this.panelINREGISTRARE.Location = new System.Drawing.Point(24, 26);
            this.panelINREGISTRARE.Name = "panelINREGISTRARE";
            this.panelINREGISTRARE.Size = new System.Drawing.Size(217, 192);
            this.panelINREGISTRARE.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 9);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.labelConectare);
            this.panel1.Controls.Add(this.labelNumeConectare);
            this.panel1.Controls.Add(this.buttonConectare);
            this.panel1.Controls.Add(this.textBoxNumeConectare);
            this.panel1.Controls.Add(this.textBoxParolaConectare);
            this.panel1.Controls.Add(this.labelParolaConectare);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(247, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 192);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stai la curent cu situatia ta scolara!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Esti deja inregistrat? Conecteaza-te!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(498, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelINREGISTRARE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelINREGISTRARE.ResumeLayout(false);
            this.panelINREGISTRARE.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeInregistrare;
        private System.Windows.Forms.Label labelInregistrare;
        private System.Windows.Forms.Label labelNumeInregistrare;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxParolaInregistrare;
        private System.Windows.Forms.Label labelConectare;
        private System.Windows.Forms.Label labelNumeConectare;
        private System.Windows.Forms.Label labelParolaConectare;
        private System.Windows.Forms.TextBox textBoxNumeConectare;
        private System.Windows.Forms.TextBox textBoxParolaConectare;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonConectare;
        private System.Windows.Forms.Panel panelINREGISTRARE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

