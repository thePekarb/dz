namespace zadanie2_Myasnikov
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценыЗаПосещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.галлереяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.добавитьКлиентаToolStripMenuItem,
            this.ценыЗаПосещениеToolStripMenuItem,
            this.галлереяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайсToolStripMenuItem,
            this.контактыToolStripMenuItem,
            this.оНасToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // ценыЗаПосещениеToolStripMenuItem
            // 
            this.ценыЗаПосещениеToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.ценыЗаПосещениеToolStripMenuItem.Name = "ценыЗаПосещениеToolStripMenuItem";
            this.ценыЗаПосещениеToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.ценыЗаПосещениеToolStripMenuItem.Text = "Цены за посещение";
            this.ценыЗаПосещениеToolStripMenuItem.Click += new System.EventHandler(this.ценыЗаПосещениеToolStripMenuItem_Click);
            // 
            // галлереяToolStripMenuItem
            // 
            this.галлереяToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.галлереяToolStripMenuItem.Name = "галлереяToolStripMenuItem";
            this.галлереяToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.галлереяToolStripMenuItem.Text = "Галлерея";
            this.галлереяToolStripMenuItem.Click += new System.EventHandler(this.галлереяToolStripMenuItem_Click);
            // 
            // прайсToolStripMenuItem
            // 
            this.прайсToolStripMenuItem.Name = "прайсToolStripMenuItem";
            this.прайсToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.прайсToolStripMenuItem.Text = "прайс";
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.контактыToolStripMenuItem.Text = "контакты";
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.оНасToolStripMenuItem.Text = "о нас";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 420);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::zadanie2_Myasnikov.Properties.Resources.зал5;
            this.pictureBox1.Location = new System.Drawing.Point(67, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 194);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::zadanie2_Myasnikov.Properties.Resources.зал4;
            this.pictureBox2.Location = new System.Drawing.Point(413, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 308);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценыЗаПосещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem галлереяToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}