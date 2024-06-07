namespace FLOWERMARKET.Properties
{
    partial class Dashboard
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
            pictureBox1 = new PictureBox();
            buttonTransaksi = new Button();
            buttonBarang = new Button();
            buttonKasir = new Button();
            buttonKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.bg_dashboard;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.Location = new Point(354, 87);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(75, 23);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.UseVisualStyleBackColor = true;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // buttonBarang
            // 
            buttonBarang.Location = new Point(252, 138);
            buttonBarang.Name = "buttonBarang";
            buttonBarang.Size = new Size(75, 23);
            buttonBarang.TabIndex = 2;
            buttonBarang.Text = "Barang";
            buttonBarang.UseVisualStyleBackColor = true;
            buttonBarang.Click += buttonBarang_Click;
            // 
            // buttonKasir
            // 
            buttonKasir.Location = new Point(354, 138);
            buttonKasir.Name = "buttonKasir";
            buttonKasir.Size = new Size(75, 23);
            buttonKasir.TabIndex = 3;
            buttonKasir.Text = "Kasir";
            buttonKasir.UseVisualStyleBackColor = true;
            buttonKasir.Click += buttonKasir_Click;
            // 
            // buttonKeluar
            // 
            buttonKeluar.Location = new Point(455, 138);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(75, 23);
            buttonKeluar.TabIndex = 4;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = true;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonKasir);
            Controls.Add(buttonBarang);
            Controls.Add(buttonTransaksi);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonTransaksi;
        private Button buttonBarang;
        private Button buttonKasir;
        private Button buttonKeluar;
    }
}