namespace rekenmachine1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.ClearKnop = new System.Windows.Forms.Button();
            this.EuroKnop = new System.Windows.Forms.Button();
            this.ProcentKnop = new System.Windows.Forms.Button();
            this.plusKnop = new System.Windows.Forms.Button();
            this.zevenKnop = new System.Windows.Forms.Button();
            this.AchtKnop = new System.Windows.Forms.Button();
            this.negenKnop = new System.Windows.Forms.Button();
            this.minKnop = new System.Windows.Forms.Button();
            this.VierKnop = new System.Windows.Forms.Button();
            this.VijfKnop = new System.Windows.Forms.Button();
            this.ZesKnop = new System.Windows.Forms.Button();
            this.KeerKnop = new System.Windows.Forms.Button();
            this.EenKnop = new System.Windows.Forms.Button();
            this.TweeKnop = new System.Windows.Forms.Button();
            this.DrieKnop = new System.Windows.Forms.Button();
            this.deelKnop = new System.Windows.Forms.Button();
            this.AnsKnop = new System.Windows.Forms.Button();
            this.NulKnop = new System.Windows.Forms.Button();
            this.KommaKnop = new System.Windows.Forms.Button();
            this.IsKnop = new System.Windows.Forms.Button();
            this.Boventext = new System.Windows.Forms.TextBox();
            this.SymboolText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(65, 36);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(171, 23);
            this.UserInputText.TabIndex = 0;
            this.UserInputText.TextChanged += new System.EventHandler(this.UserInputText_TextChanged);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.Controls.Add(this.ClearKnop, 0, 0);
            this.table.Controls.Add(this.EuroKnop, 1, 0);
            this.table.Controls.Add(this.ProcentKnop, 2, 0);
            this.table.Controls.Add(this.plusKnop, 3, 0);
            this.table.Controls.Add(this.zevenKnop, 0, 1);
            this.table.Controls.Add(this.AchtKnop, 1, 1);
            this.table.Controls.Add(this.negenKnop, 2, 1);
            this.table.Controls.Add(this.minKnop, 3, 1);
            this.table.Controls.Add(this.VierKnop, 0, 2);
            this.table.Controls.Add(this.VijfKnop, 1, 2);
            this.table.Controls.Add(this.ZesKnop, 2, 2);
            this.table.Controls.Add(this.KeerKnop, 3, 2);
            this.table.Controls.Add(this.EenKnop, 0, 3);
            this.table.Controls.Add(this.TweeKnop, 1, 3);
            this.table.Controls.Add(this.DrieKnop, 2, 3);
            this.table.Controls.Add(this.deelKnop, 3, 3);
            this.table.Controls.Add(this.AnsKnop, 0, 4);
            this.table.Controls.Add(this.NulKnop, 1, 4);
            this.table.Controls.Add(this.KommaKnop, 2, 4);
            this.table.Controls.Add(this.IsKnop, 3, 4);
            this.table.Location = new System.Drawing.Point(13, 121);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.Size = new System.Drawing.Size(259, 228);
            this.table.TabIndex = 2;
            // 
            // ClearKnop
            // 
            this.ClearKnop.CausesValidation = false;
            this.ClearKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearKnop.Location = new System.Drawing.Point(3, 3);
            this.ClearKnop.Name = "ClearKnop";
            this.ClearKnop.Size = new System.Drawing.Size(58, 39);
            this.ClearKnop.TabIndex = 0;
            this.ClearKnop.Text = "Clear";
            this.ClearKnop.UseVisualStyleBackColor = true;
            this.ClearKnop.Click += new System.EventHandler(this.ClearKnop_Click);
            // 
            // EuroKnop
            // 
            this.EuroKnop.AutoSize = true;
            this.EuroKnop.CausesValidation = false;
            this.EuroKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EuroKnop.Location = new System.Drawing.Point(67, 3);
            this.EuroKnop.Name = "EuroKnop";
            this.EuroKnop.Size = new System.Drawing.Size(58, 39);
            this.EuroKnop.TabIndex = 1;
            this.EuroKnop.Text = "€";
            this.EuroKnop.UseVisualStyleBackColor = true;
            this.EuroKnop.Click += new System.EventHandler(this.EuroKnop_Click);
            // 
            // ProcentKnop
            // 
            this.ProcentKnop.CausesValidation = false;
            this.ProcentKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcentKnop.Location = new System.Drawing.Point(131, 3);
            this.ProcentKnop.Name = "ProcentKnop";
            this.ProcentKnop.Size = new System.Drawing.Size(58, 39);
            this.ProcentKnop.TabIndex = 2;
            this.ProcentKnop.Text = "%";
            this.ProcentKnop.UseVisualStyleBackColor = true;
            this.ProcentKnop.Click += new System.EventHandler(this.ProcentKnop_Click);
            // 
            // plusKnop
            // 
            this.plusKnop.CausesValidation = false;
            this.plusKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusKnop.Location = new System.Drawing.Point(195, 3);
            this.plusKnop.Name = "plusKnop";
            this.plusKnop.Size = new System.Drawing.Size(61, 39);
            this.plusKnop.TabIndex = 3;
            this.plusKnop.Text = "+";
            this.plusKnop.UseVisualStyleBackColor = true;
            this.plusKnop.Click += new System.EventHandler(this.plusKnop_Click);
            // 
            // zevenKnop
            // 
            this.zevenKnop.CausesValidation = false;
            this.zevenKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zevenKnop.Location = new System.Drawing.Point(3, 48);
            this.zevenKnop.Name = "zevenKnop";
            this.zevenKnop.Size = new System.Drawing.Size(58, 39);
            this.zevenKnop.TabIndex = 4;
            this.zevenKnop.Text = "7";
            this.zevenKnop.UseVisualStyleBackColor = true;
            this.zevenKnop.Click += new System.EventHandler(this.zevenKnop_Click);
            // 
            // AchtKnop
            // 
            this.AchtKnop.CausesValidation = false;
            this.AchtKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AchtKnop.Location = new System.Drawing.Point(67, 48);
            this.AchtKnop.Name = "AchtKnop";
            this.AchtKnop.Size = new System.Drawing.Size(58, 39);
            this.AchtKnop.TabIndex = 5;
            this.AchtKnop.Text = "8";
            this.AchtKnop.UseVisualStyleBackColor = true;
            this.AchtKnop.Click += new System.EventHandler(this.AchtKnop_Click);
            // 
            // negenKnop
            // 
            this.negenKnop.CausesValidation = false;
            this.negenKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.negenKnop.Location = new System.Drawing.Point(131, 48);
            this.negenKnop.Name = "negenKnop";
            this.negenKnop.Size = new System.Drawing.Size(58, 39);
            this.negenKnop.TabIndex = 6;
            this.negenKnop.Text = "9";
            this.negenKnop.UseVisualStyleBackColor = true;
            this.negenKnop.Click += new System.EventHandler(this.negenKnop_Click);
            // 
            // minKnop
            // 
            this.minKnop.CausesValidation = false;
            this.minKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minKnop.Location = new System.Drawing.Point(195, 48);
            this.minKnop.Name = "minKnop";
            this.minKnop.Size = new System.Drawing.Size(61, 39);
            this.minKnop.TabIndex = 7;
            this.minKnop.Text = "-";
            this.minKnop.UseVisualStyleBackColor = true;
            this.minKnop.Click += new System.EventHandler(this.minKnop_Click);
            // 
            // VierKnop
            // 
            this.VierKnop.CausesValidation = false;
            this.VierKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VierKnop.Location = new System.Drawing.Point(3, 93);
            this.VierKnop.Name = "VierKnop";
            this.VierKnop.Size = new System.Drawing.Size(58, 39);
            this.VierKnop.TabIndex = 8;
            this.VierKnop.Text = "4";
            this.VierKnop.UseVisualStyleBackColor = true;
            this.VierKnop.Click += new System.EventHandler(this.VierKnop_Click);
            // 
            // VijfKnop
            // 
            this.VijfKnop.CausesValidation = false;
            this.VijfKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VijfKnop.Location = new System.Drawing.Point(67, 93);
            this.VijfKnop.Name = "VijfKnop";
            this.VijfKnop.Size = new System.Drawing.Size(58, 39);
            this.VijfKnop.TabIndex = 9;
            this.VijfKnop.Text = "5";
            this.VijfKnop.UseVisualStyleBackColor = true;
            this.VijfKnop.Click += new System.EventHandler(this.VijfKnop_Click);
            // 
            // ZesKnop
            // 
            this.ZesKnop.CausesValidation = false;
            this.ZesKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZesKnop.Location = new System.Drawing.Point(131, 93);
            this.ZesKnop.Name = "ZesKnop";
            this.ZesKnop.Size = new System.Drawing.Size(58, 39);
            this.ZesKnop.TabIndex = 10;
            this.ZesKnop.Text = "6";
            this.ZesKnop.UseVisualStyleBackColor = true;
            this.ZesKnop.Click += new System.EventHandler(this.ZesKnop_Click);
            // 
            // KeerKnop
            // 
            this.KeerKnop.CausesValidation = false;
            this.KeerKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeerKnop.Location = new System.Drawing.Point(195, 93);
            this.KeerKnop.Name = "KeerKnop";
            this.KeerKnop.Size = new System.Drawing.Size(61, 39);
            this.KeerKnop.TabIndex = 11;
            this.KeerKnop.Text = "*";
            this.KeerKnop.UseVisualStyleBackColor = true;
            this.KeerKnop.Click += new System.EventHandler(this.KeerKnop_Click);
            // 
            // EenKnop
            // 
            this.EenKnop.CausesValidation = false;
            this.EenKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EenKnop.Location = new System.Drawing.Point(3, 138);
            this.EenKnop.Name = "EenKnop";
            this.EenKnop.Size = new System.Drawing.Size(58, 39);
            this.EenKnop.TabIndex = 12;
            this.EenKnop.Text = "1";
            this.EenKnop.UseVisualStyleBackColor = true;
            this.EenKnop.Click += new System.EventHandler(this.EenKnop_Click);
            // 
            // TweeKnop
            // 
            this.TweeKnop.CausesValidation = false;
            this.TweeKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TweeKnop.Location = new System.Drawing.Point(67, 138);
            this.TweeKnop.Name = "TweeKnop";
            this.TweeKnop.Size = new System.Drawing.Size(58, 39);
            this.TweeKnop.TabIndex = 13;
            this.TweeKnop.Text = "2";
            this.TweeKnop.UseVisualStyleBackColor = true;
            this.TweeKnop.Click += new System.EventHandler(this.TweeKnop_Click);
            // 
            // DrieKnop
            // 
            this.DrieKnop.CausesValidation = false;
            this.DrieKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrieKnop.Location = new System.Drawing.Point(131, 138);
            this.DrieKnop.Name = "DrieKnop";
            this.DrieKnop.Size = new System.Drawing.Size(58, 39);
            this.DrieKnop.TabIndex = 14;
            this.DrieKnop.Text = "3";
            this.DrieKnop.UseVisualStyleBackColor = true;
            this.DrieKnop.Click += new System.EventHandler(this.DrieKnop_Click);
            // 
            // deelKnop
            // 
            this.deelKnop.CausesValidation = false;
            this.deelKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deelKnop.Location = new System.Drawing.Point(195, 138);
            this.deelKnop.Name = "deelKnop";
            this.deelKnop.Size = new System.Drawing.Size(61, 39);
            this.deelKnop.TabIndex = 15;
            this.deelKnop.Text = "/";
            this.deelKnop.UseVisualStyleBackColor = true;
            this.deelKnop.Click += new System.EventHandler(this.deelKnop_Click);
            // 
            // AnsKnop
            // 
            this.AnsKnop.CausesValidation = false;
            this.AnsKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnsKnop.Location = new System.Drawing.Point(3, 183);
            this.AnsKnop.Name = "AnsKnop";
            this.AnsKnop.Size = new System.Drawing.Size(58, 42);
            this.AnsKnop.TabIndex = 16;
            this.AnsKnop.Text = "Ans";
            this.AnsKnop.UseVisualStyleBackColor = true;
            this.AnsKnop.Click += new System.EventHandler(this.AnsKnop_Click);
            // 
            // NulKnop
            // 
            this.NulKnop.CausesValidation = false;
            this.NulKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NulKnop.Location = new System.Drawing.Point(67, 183);
            this.NulKnop.Name = "NulKnop";
            this.NulKnop.Size = new System.Drawing.Size(58, 42);
            this.NulKnop.TabIndex = 17;
            this.NulKnop.Text = "0";
            this.NulKnop.UseVisualStyleBackColor = true;
            this.NulKnop.Click += new System.EventHandler(this.NulKnop_Click);
            // 
            // KommaKnop
            // 
            this.KommaKnop.CausesValidation = false;
            this.KommaKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KommaKnop.Location = new System.Drawing.Point(131, 183);
            this.KommaKnop.Name = "KommaKnop";
            this.KommaKnop.Size = new System.Drawing.Size(58, 42);
            this.KommaKnop.TabIndex = 18;
            this.KommaKnop.Text = ",";
            this.KommaKnop.UseVisualStyleBackColor = true;
            this.KommaKnop.Click += new System.EventHandler(this.KommaKnop_Click);
            // 
            // IsKnop
            // 
            this.IsKnop.CausesValidation = false;
            this.IsKnop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsKnop.Location = new System.Drawing.Point(195, 183);
            this.IsKnop.Name = "IsKnop";
            this.IsKnop.Size = new System.Drawing.Size(61, 42);
            this.IsKnop.TabIndex = 19;
            this.IsKnop.Text = "=";
            this.IsKnop.UseVisualStyleBackColor = true;
            this.IsKnop.Click += new System.EventHandler(this.IsKnop_Click);
            // 
            // Boventext
            // 
            this.Boventext.Location = new System.Drawing.Point(136, 7);
            this.Boventext.Name = "Boventext";
            this.Boventext.Size = new System.Drawing.Size(100, 23);
            this.Boventext.TabIndex = 3;
            // 
            // SymboolText
            // 
            this.SymboolText.Location = new System.Drawing.Point(243, 23);
            this.SymboolText.Name = "SymboolText";
            this.SymboolText.Size = new System.Drawing.Size(26, 23);
            this.SymboolText.TabIndex = 4;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(65, 75);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(171, 23);
            this.ResultText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.IsKnop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.ClearKnop;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.SymboolText);
            this.Controls.Add(this.Boventext);
            this.Controls.Add(this.table);
            this.Controls.Add(this.UserInputText);
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            this.Load += new System.EventHandler(this.EuroKnop_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button ClearKnop;
        private System.Windows.Forms.Button EuroKnop;
        private System.Windows.Forms.Button ProcentKnop;
        private System.Windows.Forms.Button plusKnop;
        private System.Windows.Forms.Button zevenKnop;
        private System.Windows.Forms.Button AchtKnop;
        private System.Windows.Forms.Button negenKnop;
        private System.Windows.Forms.Button minKnop;
        private System.Windows.Forms.Button VierKnop;
        private System.Windows.Forms.Button VijfKnop;
        private System.Windows.Forms.Button ZesKnop;
        private System.Windows.Forms.Button KeerKnop;
        private System.Windows.Forms.Button EenKnop;
        private System.Windows.Forms.Button TweeKnop;
        private System.Windows.Forms.Button DrieKnop;
        private System.Windows.Forms.Button deelKnop;
        private System.Windows.Forms.Button AnsKnop;
        private System.Windows.Forms.Button NulKnop;
        private System.Windows.Forms.Button KommaKnop;
        private System.Windows.Forms.Button IsKnop;
        private System.Windows.Forms.TextBox Boventext;
        private System.Windows.Forms.TextBox SymboolText;
        private System.Windows.Forms.TextBox ResultText;
    }
}

