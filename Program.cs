using tpmod07_kelompok;

DataMahasiswa103022300121 dataMahasiswa103022300121 = new DataMahasiswa103022300121();
KuliahMahasiswa103022300121 kuliahMahasiswa103022300121 = new KuliahMahasiswa103022300121();

// file json terletak pada nama_project\bin\Debug\net8.0
dataMahasiswa103022300121.ReadJSON("tp7_1_103022300121.json");
kuliahMahasiswa103022300121.ReadJSON("tp7_2_103022300121.json");