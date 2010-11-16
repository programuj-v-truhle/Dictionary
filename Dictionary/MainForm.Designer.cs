namespace Dictionary
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vyhledavaciBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vymenit = new System.Windows.Forms.Button();
            this.slovaB = new System.Windows.Forms.ListBox();
            this.slovaA = new System.Windows.Forms.ListBox();
            this.popisek_jazykB = new System.Windows.Forms.Label();
            this.popisek_jazykA = new System.Windows.Forms.Label();
            this.stavovyRadek = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vyhledavaciBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vyhledávání";
            // 
            // vyhledavaciBox
            // 
            this.vyhledavaciBox.Location = new System.Drawing.Point(58, 20);
            this.vyhledavaciBox.Name = "vyhledavaciBox";
            this.vyhledavaciBox.Size = new System.Drawing.Size(260, 20);
            this.vyhledavaciBox.TabIndex = 1;
            this.vyhledavaciBox.TextChanged += new System.EventHandler(this.vyhledavaciBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slovo: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vymenit);
            this.groupBox2.Controls.Add(this.slovaB);
            this.groupBox2.Controls.Add(this.slovaA);
            this.groupBox2.Controls.Add(this.popisek_jazykB);
            this.groupBox2.Controls.Add(this.popisek_jazykA);
            this.groupBox2.Location = new System.Drawing.Point(2, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slova";
            // 
            // vymenit
            // 
            this.vymenit.Location = new System.Drawing.Point(243, 10);
            this.vymenit.Name = "vymenit";
            this.vymenit.Size = new System.Drawing.Size(75, 23);
            this.vymenit.TabIndex = 4;
            this.vymenit.Text = "Otočit";
            this.vymenit.UseVisualStyleBackColor = true;
            this.vymenit.Click += new System.EventHandler(this.vymenit_Click);
            // 
            // slovaB
            // 
            this.slovaB.FormattingEnabled = true;
            this.slovaB.Location = new System.Drawing.Point(177, 56);
            this.slovaB.Name = "slovaB";
            this.slovaB.Size = new System.Drawing.Size(144, 342);
            this.slovaB.TabIndex = 3;
            // 
            // slovaA
            // 
            this.slovaA.FormattingEnabled = true;
            this.slovaA.Location = new System.Drawing.Point(13, 56);
            this.slovaA.Name = "slovaA";
            this.slovaA.Size = new System.Drawing.Size(143, 342);
            this.slovaA.TabIndex = 2;
            // 
            // popisek_jazykB
            // 
            this.popisek_jazykB.AutoSize = true;
            this.popisek_jazykB.Location = new System.Drawing.Point(174, 31);
            this.popisek_jazykB.Name = "popisek_jazykB";
            this.popisek_jazykB.Size = new System.Drawing.Size(44, 13);
            this.popisek_jazykB.TabIndex = 1;
            this.popisek_jazykB.Text = "Jazyk B";
            // 
            // popisek_jazykA
            // 
            this.popisek_jazykA.AutoSize = true;
            this.popisek_jazykA.Location = new System.Drawing.Point(10, 31);
            this.popisek_jazykA.Name = "popisek_jazykA";
            this.popisek_jazykA.Size = new System.Drawing.Size(44, 13);
            this.popisek_jazykA.TabIndex = 0;
            this.popisek_jazykA.Text = "Jazyk A";
            // 
            // stavovyRadek
            // 
            this.stavovyRadek.Location = new System.Drawing.Point(0, 477);
            this.stavovyRadek.Name = "stavovyRadek";
            this.stavovyRadek.Size = new System.Drawing.Size(332, 22);
            this.stavovyRadek.TabIndex = 2;
            this.stavovyRadek.Text = "Připraven";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 499);
            this.Controls.Add(this.stavovyRadek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slovník";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox vyhledavaciBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip stavovyRadek;
        private System.Windows.Forms.ListBox slovaB;
        private System.Windows.Forms.ListBox slovaA;
        private System.Windows.Forms.Label popisek_jazykB;
        private System.Windows.Forms.Label popisek_jazykA;
        private System.Windows.Forms.Button vymenit;
    }
}

