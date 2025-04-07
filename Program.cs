// See https://aka.ms/new-console-template for more information
using cobaJSON1;
using cobaJSON2;

public class Program
{
    public static void Main(string[] args)
    {
        /* 
         * According to Microsoft guide to deserialize JSON file with 'using System.text.Json', 
         * if using File.ReadAllText(), the file must be in the same directory as the executable. 
         * So no need to specify the path.
         */
        string jsonFilePath = "tp7_1_103022300082.json";
        DataMahasiswa_103022300082 mahasiswa = DataMahasiswa_103022300082.ReadJSON(jsonFilePath);
        mahasiswa.PrintMahasiswa();

        // KuliahMahasiswa_103022300082 kuliahMahasiswa = new KuliahMahasiswa_103022300082();
        // kuliahMahasiswa.ReadJSON("tp7_2_103022300082.json");
        KuliahMahasiswa_103022300082.ReadJSON("tp7_2_103022300082.json");
    }
}