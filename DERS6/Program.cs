

#region Async Ve await

async Task<int> X()
{
    return 33;
}

//BURADA DİKKAT ÇEKİLMEK İSTENEN 
// İKİSİ ARASI FARK
Task<int> Y()
{
    return 33;
}
#endregion



#region Await example1
async Task<string> ReadFile()
{
    StreamReader streamReader = new("Liste.txt");
    string content = await streamReader.ReadToEndAsync();
    return content;

}
//readfile dosyasının ıcerıgını okuduk
string result = await ReadFile();
Console.WriteLine(result);

#endregion



#region ConfigureAwait

async Task<string> ReadFileAsync2()
{
    StreamReader streamReader = new("Liste.txt");
    string content = await streamReader.ReadToEndAsync().ConfigureAwait(false);

    //Asenkron işlemden sonra çalışacak kod farklı bir contextte çalışabilir diyoruz
    //Bu kod artık özgürce herhangi bir thread'de çalışabilir
    Console.WriteLine("End.");
    await Console.Out.WriteLineAsync(content);

    return content;
}
await ReadFileAsync2();
#endregion


#region  CancellationTokenAnd CancellationTokenSource

async Task DoWorkAsync(CancellationToken cancellationToken)
{
    for (int i = 0; i < 10; i++)
    {
       cancellationToken.ThrowIfCancellationRequested();  // İptal edildi mi diye kontrol ediliyor
        await Console.Out.WriteLineAsync($"{i}");
        await Task.Delay(1000);
    }
    Console.WriteLine("Work Completed...");
}


 
CancellationTokenSource cancellationTokenSource = new();
Task.Run(async () =>
{
    await Task.Delay(3000); // 3 saniye sonra işlemi cancel et diyoruz 
    await cancellationTokenSource.CancelAsync();
});

try
{
    await DoWorkAsync(cancellationTokenSource.Token);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

#endregion


