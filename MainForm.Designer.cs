namespace Mission03_Sistem_Data_Mahasiswa
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnInputData;
        private MaterialSkin.Controls.MaterialRaisedButton btnLihatData;
        private MaterialSkin.Controls.MaterialRaisedButton btnKeluar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnInputData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLihatData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnKeluar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnInputData
            // 
            this.btnInputData.Depth = 0;
            this.btnInputData.Location = new System.Drawing.Point(82, 94);
            this.btnInputData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Primary = true;
            this.btnInputData.Size = new System.Drawing.Size(271, 30);
            this.btnInputData.TabIndex = 0;
            this.btnInputData.Text = "Input Data Mahasiswa";
            this.btnInputData.UseVisualStyleBackColor = true;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Depth = 0;
            this.btnLihatData.Location = new System.Drawing.Point(82, 134);
            this.btnLihatData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Primary = true;
            this.btnLihatData.Size = new System.Drawing.Size(271, 30);
            this.btnLihatData.TabIndex = 1;
            this.btnLihatData.Text = "Lihat Data Mahasiswa";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Depth = 0;
            this.btnKeluar.Location = new System.Drawing.Point(139, 234);
            this.btnKeluar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Primary = true;
            this.btnKeluar.Size = new System.Drawing.Size(148, 30);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(436, 345);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnInputData);
            this.Name = "MainForm";
            this.Text = "Sistem Data Mahasiswa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}
