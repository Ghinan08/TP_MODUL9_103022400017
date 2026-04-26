using TP_MODUL9_103022400017;

CovidConfig covidConfig = new CovidConfig();
JalankanPengecekan(covidConfig);

Console.WriteLine("Mengubah satuan suhu");
covidConfig.UbahSatuan();
JalankanPengecekan(covidConfig);

static void JalankanPengecekan(CovidConfig config)
{
    Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.config.satuan_suhu}: ");
    double suhu = Convert.ToDouble(Console.ReadLine());
    Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");
    int hariDemam = Convert.ToInt32(Console.ReadLine());
    bool statusSuhu = false;

    if (config.config.satuan_suhu == "celcius")
    {
        if (suhu >= 36.5 && suhu <= 37.5)
        {
            statusSuhu = true;
        }
    }
    else if (config.config.satuan_suhu == "fahrenheit")
    {
        if (suhu >= 97.7 && suhu <= 99.5)
        {
            statusSuhu = true;
        }
    }

    if (statusSuhu && hariDemam < config.config.batas_hari_deman)
    {
        Console.WriteLine(config.config.pesan_diterima);
    }
    else
    {
        Console.WriteLine(config.config.pesan_ditolak);
    }
}