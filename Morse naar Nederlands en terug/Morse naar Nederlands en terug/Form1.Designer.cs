namespace Morse_naar_Nederlands_en_terug
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MorseKnop = new System.Windows.Forms.Button();
            this.NederlandsKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 228);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MorseKnop
            // 
            this.MorseKnop.Location = new System.Drawing.Point(311, 266);
            this.MorseKnop.Name = "MorseKnop";
            this.MorseKnop.Size = new System.Drawing.Size(195, 66);
            this.MorseKnop.TabIndex = 1;
            this.MorseKnop.Text = "Vertaal naar Morse";
            this.MorseKnop.UseVisualStyleBackColor = true;
            this.MorseKnop.Click += new System.EventHandler(this.MorseKnop_Click);
            // 
            // NederlandsKnop
            // 
            this.NederlandsKnop.Location = new System.Drawing.Point(311, 338);
            this.NederlandsKnop.Name = "NederlandsKnop";
            this.NederlandsKnop.Size = new System.Drawing.Size(195, 70);
            this.NederlandsKnop.TabIndex = 2;
            this.NederlandsKnop.Text = "Vertaal terug";
            this.NederlandsKnop.UseVisualStyleBackColor = true;
            this.NederlandsKnop.Click += new System.EventHandler(this.NederlandsKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NederlandsKnop);
            this.Controls.Add(this.MorseKnop);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MorseKnop;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NederlandsKnop;
    }
}

