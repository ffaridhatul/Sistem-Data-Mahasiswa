using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03_Sistem_Data_Mahasiswa
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MahasiswaRepository
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();

        public void TambahMahasiswa(Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            return mahasiswaList;
        }

        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            return mahasiswaList.FirstOrDefault(m => m.NIM == nim);
        }

        public void HapusMahasiswa(string nim)
        {
            var mahasiswa = GetMahasiswaByNIM(nim);
            if (mahasiswa == null)
            {
                throw new ArgumentException("Data mahasiswa tidak ditemukan.");
            }

            mahasiswaList.Remove(mahasiswa);
        }
    }
}
