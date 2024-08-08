using MaterialSkin;
using MaterialSkin.Controls;
using Mission02_Sistem_Data_buku;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mission03_Sistem_Data_Mahasiswa
{
    public partial class DisplayForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public DisplayForm()
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

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string searchQuery = "")
        {
            MahasiswaService service = new MahasiswaService();
            var mahasiswaList = service.GetAllMahasiswa();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                mahasiswaList = mahasiswaList
                    .Where(m => m.Nama.Contains(searchQuery) || m.NIM.Contains(searchQuery))
                    .ToList();
            }

            dataGridView1.Rows.Clear();
            foreach (var mahasiswa in mahasiswaList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = mahasiswa.Nama;
                row.Cells[1].Value = mahasiswa.NIM;
                row.Cells[2].Value = mahasiswa.Jurusan;

                if (File.Exists(mahasiswa.FotoPath))
                {
                    Image img = Image.FromFile(mahasiswa.FotoPath);
                    row.Cells[3].Value = img;
                    // Menyesuaikan lebar kolom dan tinggi baris berdasarkan ukuran gambar 3x4
                    int imgWidth = 75; // 3 cm dengan resolusi 25 dpi (75 pixels)
                    int imgHeight = 100; // 4 cm dengan resolusi 25 dpi (100 pixels)
                    dataGridView1.Columns[3].Width = imgWidth;
                    row.Height = imgHeight;
                }
                else
                {
                    row.Cells[3].Value = null;
                }

                row.Cells[4].Value = mahasiswa.FotoPath;

                dataGridView1.Rows.Add(row);
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nim = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                MahasiswaService service = new MahasiswaService();

                try
                {
                    service.HapusMahasiswa(nim);
                    MessageBox.Show("Data mahasiswa berhasil dihapus.");
                    LoadData(txtSearch.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
