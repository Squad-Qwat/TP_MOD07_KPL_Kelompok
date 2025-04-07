using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace tpmod07_kelompok.services
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa_103022300144
    {
        public async Task ReadJson()
        {
            string fileName = "tp7_1_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);

            Mahasiswa? mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa?>(stream);
            Console.WriteLine("Nama: " + mahasiswa?.nama?.depan + " " + mahasiswa?.nama?.belakang + " dengan nim: " + mahasiswa?.nim + " dari fakultas: " + mahasiswa?.fakultas);
        }
    }
}
