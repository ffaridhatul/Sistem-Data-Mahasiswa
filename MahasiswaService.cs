using System;
using System.Collections.Generic;
using System.IO;
using Mission02_Sistem_Data_buku;
using Newtonsoft.Json;

namespace Mission03_Sistem_Data_Mahasiswa
{
    public class MahasiswaService
    {
        private const string DataFilePath = "mahasiswa.json";
        private List<Mahasiswa> mahasiswaList;

        public MahasiswaService()
        {
            mahasiswaList = LoadData();
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            return mahasiswaList;
        }

        public void TambahMahasiswa(Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            SaveData();
        }

        public void HapusMahasiswa(string nim)
        {
            var mahasiswa = GetMahasiswaByNIM(nim);
            if (mahasiswa != null)
            {
                mahasiswaList.Remove(mahasiswa);
                SaveData();
            }
            else
            {
                throw new ArgumentException("Mahasiswa tidak ditemukan.");
            }
        }

        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            return mahasiswaList.Find(m => m.NIM == nim);
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(mahasiswaList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(DataFilePath, json);
        }

        private List<Mahasiswa> LoadData()
        {
            if (File.Exists(DataFilePath))
            {
                var json = File.ReadAllText(DataFilePath);
                return JsonConvert.DeserializeObject<List<Mahasiswa>>(json) ?? new List<Mahasiswa>();
            }
            return new List<Mahasiswa>();
        }
    }
}
