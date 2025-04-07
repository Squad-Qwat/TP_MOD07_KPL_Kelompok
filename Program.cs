// See https://aka.ms/new-console-template for more information
using cobaJSON1;
using cobaJSON2;

public class Program
{
    public static async Task Main(string[] args)
    {
        /* 
         * According to Microsoft guide to deserialize JSON file with 'using System.text.Json', 
         * if using File.ReadAllText(), the file must be in the same directory as the executable. 
         * So no need to specify the path.
         */
        DataMahasiswa_103022300082 mahasiswa = new DataMahasiswa_103022300082();
        await mahasiswa.ReadJson();
        mahasiswa.PrintMahasiswa();

        // KuliahMahasiswa_103022300082 kuliahMahasiswa = new KuliahMahasiswa_103022300082();
        // kuliahMahasiswa.ReadJSON("tp7_2_103022300082.json");
        KuliahMahasiswa_103022300082.ReadJSON("tp7_2_103022300082.json");
    }
}