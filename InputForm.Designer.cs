namespace Mission03_Sistem_Data_Mahasiswa
{
    partial class InputForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialLabel lblNama;
        private MaterialSkin.Controls.MaterialLabel lblNIM;
        private MaterialSkin.Controls.MaterialLabel lblJurusan;
        private MaterialSkin.Controls.MaterialLabel lblFoto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNama;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIM;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJurusan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFotoPath;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;

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
            this.lblNama = new MaterialSkin.Controls.MaterialLabel();
            this.lblNIM = new MaterialSkin.Controls.MaterialLabel();
            this.lblJurusan = new MaterialSkin.Controls.MaterialLabel();
            this.lblFoto = new MaterialSkin.Controls.MaterialLabel();
            this.txtNama = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNIM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJurusan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFotoPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBrowse = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Depth = 0;
            this.lblNama.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNama.Location = new System.Drawing.Point(47, 121);
            this.lblNama.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(141, 27);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama             :";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Depth = 0;
            this.lblNIM.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNIM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNIM.Location = new System.Drawing.Point(45, 169);
            this.lblNIM.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(143, 27);
            this.lblNIM.TabIndex = 1;
            this.lblNIM.Text = "NIM                 :";
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Depth = 0;
            this.lblJurusan.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblJurusan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJurusan.Location = new System.Drawing.Point(45, 217);
            this.lblJurusan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(140, 27);
            this.lblJurusan.TabIndex = 2;
            this.lblJurusan.Text = "Jurusan         :";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Depth = 0;
            this.lblFoto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFoto.Location = new System.Drawing.Point(43, 271);
            this.lblFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(142, 27);
            this.lblFoto.TabIndex = 3;
            this.lblFoto.Text = "Foto                :";
            // 
            // txtNama
            // 
            this.txtNama.Depth = 0;
            this.txtNama.Hint = "";
            this.txtNama.Location = new System.Drawing.Point(186, 121);
            this.txtNama.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.SelectedText = "";
            this.txtNama.SelectionLength = 0;
            this.txtNama.SelectionStart = 0;
            this.txtNama.Size = new System.Drawing.Size(200, 32);
            this.txtNama.TabIndex = 4;
            this.txtNama.UseSystemPasswordChar = false;
            // 
            // txtNIM
            // 
            this.txtNIM.Depth = 0;
            this.txtNIM.Hint = "";
            this.txtNIM.Location = new System.Drawing.Point(186, 169);
            this.txtNIM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.PasswordChar = '\0';
            this.txtNIM.SelectedText = "";
            this.txtNIM.SelectionLength = 0;
            this.txtNIM.SelectionStart = 0;
            this.txtNIM.Size = new System.Drawing.Size(200, 32);
            this.txtNIM.TabIndex = 5;
            this.txtNIM.UseSystemPasswordChar = false;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Depth = 0;
            this.txtJurusan.Hint = "";
            this.txtJurusan.Location = new System.Drawing.Point(186, 217);
            this.txtJurusan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.PasswordChar = '\0';
            this.txtJurusan.SelectedText = "";
            this.txtJurusan.SelectionLength = 0;
            this.txtJurusan.SelectionStart = 0;
            this.txtJurusan.Size = new System.Drawing.Size(200, 32);
            this.txtJurusan.TabIndex = 6;
            this.txtJurusan.UseSystemPasswordChar = false;
            // 
            // txtFotoPath
            // 
            this.txtFotoPath.Depth = 0;
            this.txtFotoPath.Enabled = false;
            this.txtFotoPath.Hint = "";
            this.txtFotoPath.Location = new System.Drawing.Point(186, 271);
            this.txtFotoPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFotoPath.Name = "txtFotoPath";
            this.txtFotoPath.PasswordChar = '\0';
            this.txtFotoPath.SelectedText = "";
            this.txtFotoPath.SelectionLength = 0;
            this.txtFotoPath.SelectionStart = 0;
            this.txtFotoPath.Size = new System.Drawing.Size(200, 32);
            this.txtFotoPath.TabIndex = 10;
            this.txtFotoPath.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(177, 483);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Depth = 0;
            this.btnBrowse.Location = new System.Drawing.Point(308, 483);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Primary = true;
            this.btnBrowse.Size = new System.Drawing.Size(91, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(232, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // InputForm
            // 
            this.ClientSize = new System.Drawing.Size(464, 552);
            this.Controls.Add(this.txtFotoPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJurusan);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblNama);
            this.Name = "InputForm";
            this.Text = "Input Data Mahasiswa";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
