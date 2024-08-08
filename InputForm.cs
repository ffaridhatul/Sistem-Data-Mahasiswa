using MaterialSkin;
using MaterialSkin.Controls;
using Mission02_Sistem_Data_buku;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mission03_Sistem_Data_Mahasiswa
{
    public partial class InputForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public InputForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtNIM.Text) || string.IsNullOrEmpty(txtJurusan.Text) || pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Semua data harus diisi.");
                return;
            }

            // Simpan foto ke direktori yang ditentukan
            string fotoDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");
            if (!Directory.Exists(fotoDirectory))
            {
                Directory.CreateDirectory(fotoDirectory);
            }
            string fotoPath = Path.Combine(fotoDirectory, Path.GetFileName(pictureBox1.ImageLocation));

            // Ubah ukuran gambar menjadi 3x4 sebelum disimpan
            using (Image img = Image.FromFile(pictureBox1.ImageLocation))
            {
                using (Image resizedImg = ResizeImage(img, 300, 400)) // 3x4 cm dengan resolusi 100 dpi
                {
                    resizedImg.Save(fotoPath);
                }
            }

            Mahasiswa mahasiswa = new Mahasiswa
            {
                Nama = txtNama.Text,
                NIM = txtNIM.Text,
                Jurusan = txtJurusan.Text,
                FotoPath = fotoPath
            };

            MahasiswaService service = new MahasiswaService();
            service.TambahMahasiswa(mahasiswa);

            MessageBox.Show("Data mahasiswa berhasil disimpan.");
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                txtFotoPath.Text = openFileDialog.FileName; // Menampilkan path foto
            }
        }

        private static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
