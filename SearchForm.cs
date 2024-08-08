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
    public partial class SearchForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public SearchForm()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MahasiswaService service = new MahasiswaService();
            var mahasiswaList = service.GetAllMahasiswa();

            var result = mahasiswaList
                .Where(m => m.Nama.Contains(txtSearch.Text) || m.NIM.Contains(txtSearch.Text))
                .ToList();

            dataGridView1.Rows.Clear();
            foreach (var mahasiswa in result)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = mahasiswa.Nama;
                row.Cells[1].Value = mahasiswa.NIM;
                row.Cells[2].Value = mahasiswa.Jurusan;

                if (File.Exists(mahasiswa.FotoPath))
                {
                    row.Cells[3].Value = Image.FromFile(mahasiswa.FotoPath);
                }
                else
                {
                    row.Cells[3].Value = null;
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
