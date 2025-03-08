namespace Lab2
{
    partial class MyForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxGeneratedKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxOriginalBinary = new System.Windows.Forms.TextBox();
            this.txtbxResultBinary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnEncode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // txtbxGeneratedKey
            // 
            this.txtbxGeneratedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxGeneratedKey.Location = new System.Drawing.Point(521, 69);
            this.txtbxGeneratedKey.Multiline = true;
            this.txtbxGeneratedKey.Name = "txtbxGeneratedKey";
            this.txtbxGeneratedKey.ReadOnly = true;
            this.txtbxGeneratedKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxGeneratedKey.Size = new System.Drawing.Size(476, 128);
            this.txtbxGeneratedKey.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(516, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 29);
            this.label7.TabIndex = 55;
            this.label7.Text = "Сгенерированный ключ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(516, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Результат в двоичном виде";
            // 
            // txtbxOriginalBinary
            // 
            this.txtbxOriginalBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxOriginalBinary.Location = new System.Drawing.Point(12, 248);
            this.txtbxOriginalBinary.Multiline = true;
            this.txtbxOriginalBinary.Name = "txtbxOriginalBinary";
            this.txtbxOriginalBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxOriginalBinary.Size = new System.Drawing.Size(476, 160);
            this.txtbxOriginalBinary.TabIndex = 53;
            this.txtbxOriginalBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // txtbxResultBinary
            // 
            this.txtbxResultBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxResultBinary.Location = new System.Drawing.Point(521, 248);
            this.txtbxResultBinary.Multiline = true;
            this.txtbxResultBinary.Name = "txtbxResultBinary";
            this.txtbxResultBinary.ReadOnly = true;
            this.txtbxResultBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxResultBinary.Size = new System.Drawing.Size(476, 159);
            this.txtbxResultBinary.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Введите битовую строку (26 бит)";
            // 
            // txtbxKey
            // 
            this.txtbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxKey.Location = new System.Drawing.Point(12, 69);
            this.txtbxKey.MaxLength = 26;
            this.txtbxKey.Multiline = true;
            this.txtbxKey.Name = "txtbxKey";
            this.txtbxKey.Size = new System.Drawing.Size(476, 36);
            this.txtbxKey.TabIndex = 49;
            this.txtbxKey.Text = "11111111111111111111111111";
            this.txtbxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Введите исходный текст в двоичном виде";
            // 
            // bttnEncode
            // 
            this.bttnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnEncode.Location = new System.Drawing.Point(168, 150);
            this.bttnEncode.Name = "bttnEncode";
            this.bttnEncode.Size = new System.Drawing.Size(191, 47);
            this.bttnEncode.TabIndex = 47;
            this.bttnEncode.Text = "Зашифровать";
            this.bttnEncode.UseVisualStyleBackColor = true;
            this.bttnEncode.Click += new System.EventHandler(this.bttnEncode_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 422);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtbxGeneratedKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxOriginalBinary);
            this.Controls.Add(this.txtbxResultBinary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnEncode);
            this.Name = "MyForm";
            this.Text = "лаб2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxGeneratedKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxOriginalBinary;
        private System.Windows.Forms.TextBox txtbxResultBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnEncode;
    }
}

