using System;
using System.IO;
using System.Text.Json;
// using Newtonsoft.Json;

namespace cobaJSON1
{
    public class Name 
    {
        public string depan {  get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa_103022300082
    {
        public string NIM { get; set; }
        public List<Name> Nama { get; set; }
        public string Fakultas { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public DataMahasiswa_103022300082() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        //public string GetNIM() { return nim; }
        //public void SetNIM(string nim) { this.nim = nim; }
        //public string GetNamaDepan() { return namadepan; }
        //public void SetNamaDepan(string namadepan) { this.namadepan = namadepan; }
        //public string GetNamaBelakang() { return namabelakang; }
        //public void SetNamaBelakang(string namabelakang) { this.namabelakang = namabelakang; }
        //public string GetFakultas() { return fakultas; }
        //public void SetFakultas(string fakultas) { this.fakultas = fakultas; }

        public static DataMahasiswa_103022300082 ReadJSON(string fileName)
        {
            try
            {
                string jsonData = File.ReadAllText(fileName);
                DataMahasiswa_103022300082 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103022300082>(jsonData)!;
                // DataMahasiswa_103022300082 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa_103022300082>(jsonData);

                return mahasiswa;
                // return JsonSerializer.Deserialize<DataMahasiswa>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null;
        }

        public void PrintMahasiswa()
        {
            Console.WriteLine($"Nama {Nama} dengan nim {NIM} dari fakultas {Fakultas}");
        }
    }
}
