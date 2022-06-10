
namespace obssistemi
{
    partial class ogretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmen));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.txtogretmensoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtogretmenadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnraporlar = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip2.TabIndex = 91;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Anasayfa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Çıkış";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 167);
            this.dataGridView1.TabIndex = 324;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(617, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 323;
            this.label11.Text = "Raporlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(299, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 321;
            this.label9.Text = "Listele";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(469, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 320;
            this.label8.Text = "Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(617, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 319;
            this.label7.Text = "Ara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(453, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 318;
            this.label6.Text = "Güncelle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(299, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 317;
            this.label10.Text = "Ekle";
            // 
            // txtbrans
            // 
            this.txtbrans.Location = new System.Drawing.Point(170, 177);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(200, 20);
            this.txtbrans.TabIndex = 339;
            // 
            // txtogretmensoyadi
            // 
            this.txtogretmensoyadi.Location = new System.Drawing.Point(170, 129);
            this.txtogretmensoyadi.Name = "txtogretmensoyadi";
            this.txtogretmensoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtogretmensoyadi.TabIndex = 338;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 337;
            this.label4.Text = "Öğretmen Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 336;
            this.label3.Text = "Öğretmen Soyadı:";
            // 
            // txtogretmenadi
            // 
            this.txtogretmenadi.Location = new System.Drawing.Point(170, 79);
            this.txtogretmenadi.Name = "txtogretmenadi";
            this.txtogretmenadi.Size = new System.Drawing.Size(200, 20);
            this.txtogretmenadi.TabIndex = 335;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 334;
            this.label2.Text = "Öğretmen Adı:";
            // 
            // btnraporlar
            // 
            this.btnraporlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnraporlar.BackgroundImage")));
            this.btnraporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnraporlar.Location = new System.Drawing.Point(562, 344);
            this.btnraporlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnraporlar.Name = "btnraporlar";
            this.btnraporlar.Size = new System.Drawing.Size(49, 44);
            this.btnraporlar.TabIndex = 322;
            this.btnraporlar.UseVisualStyleBackColor = true;
            this.btnraporlar.Click += new System.EventHandler(this.btnraporlar_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistele.BackgroundImage")));
            this.btnlistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistele.Location = new System.Drawing.Point(244, 346);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(49, 42);
            this.btnlistele.TabIndex = 316;
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.Location = new System.Drawing.Point(388, 346);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(49, 42);
            this.btnsil.TabIndex = 315;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Transparent;
            this.btnara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnara.BackgroundImage")));
            this.btnara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnara.Location = new System.Drawing.Point(562, 278);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(49, 41);
            this.btnara.TabIndex = 314;
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguncelle.BackgroundImage")));
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.Location = new System.Drawing.Point(388, 278);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(49, 42);
            this.btnguncelle.TabIndex = 313;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Transparent;
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.Location = new System.Drawing.Point(244, 278);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(49, 42);
            this.btnekle.TabIndex = 312;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::obssistemi.Properties.Resources.resim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 513);
            this.Controls.Add(this.txtbrans);
            this.Controls.Add(this.txtogretmensoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtogretmenadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnraporlar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRETMENLER";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnraporlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.TextBox txtogretmensoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtogretmenadi;
        private System.Windows.Forms.Label label2;
    }
}