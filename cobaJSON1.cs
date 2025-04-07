using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace cobaJSON1
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

    public class DataMahasiswa_103022300082
    {
        Mahasiswa? mahasiswa;
        public async Task ReadJson()
        {
            string fileName = "tp7_1_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);

            mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa?>(stream);
        }

        public void PrintMahasiswa()
        {
            Console.WriteLine("Nama: " + mahasiswa?.nama?.depan + " " + mahasiswa?.nama?.belakang + " dengan nim: " + mahasiswa?.nim + " dari fakultas: " + mahasiswa?.fakultas);
        }
    }
}
