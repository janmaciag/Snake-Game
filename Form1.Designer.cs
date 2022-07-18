namespace waz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wybierzKolorWężaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czarnożToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskizielonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czerwonybiałyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 540);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.RysowanieWeza);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(492, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(548, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wciśnij Enter aby zacząć";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzKolorWężaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wybierzKolorWężaToolStripMenuItem
            // 
            this.wybierzKolorWężaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czarnożToolStripMenuItem,
            this.niebieskizielonyToolStripMenuItem,
            this.czerwonybiałyToolStripMenuItem});
            this.wybierzKolorWężaToolStripMenuItem.Name = "wybierzKolorWężaToolStripMenuItem";
            this.wybierzKolorWężaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.wybierzKolorWężaToolStripMenuItem.Text = "Wybierz kolor węża";
            // 
            // czarnożToolStripMenuItem
            // 
            this.czarnożToolStripMenuItem.Name = "czarnożToolStripMenuItem";
            this.czarnożToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.czarnożToolStripMenuItem.Text = "Czarny/żółty";
            this.czarnożToolStripMenuItem.Click += new System.EventHandler(this.czarnożToolStripMenuItem_Click);
            // 
            // niebieskizielonyToolStripMenuItem
            // 
            this.niebieskizielonyToolStripMenuItem.Name = "niebieskizielonyToolStripMenuItem";
            this.niebieskizielonyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.niebieskizielonyToolStripMenuItem.Text = "Niebieski/zielony";
            this.niebieskizielonyToolStripMenuItem.Click += new System.EventHandler(this.niebieskizielonyToolStripMenuItem_Click);
            // 
            // czerwonybiałyToolStripMenuItem
            // 
            this.czerwonybiałyToolStripMenuItem.Name = "czerwonybiałyToolStripMenuItem";
            this.czerwonybiałyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.czerwonybiałyToolStripMenuItem.Text = "Czerwony/biały";
            this.czerwonybiałyToolStripMenuItem.Click += new System.EventHandler(this.czerwonybiałyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RysowanieWeza);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wybierzKolorWężaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czarnożToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niebieskizielonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czerwonybiałyToolStripMenuItem;
    }
}

