using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    class DataMahasiswa103022300121
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON(string filePath)
        {
            string json = File.ReadAllText(filePath);
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json);
            Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.depan + " dengan nim " + data.nim + " dari fakultas " + data.fakultas);
        }

    }
}
