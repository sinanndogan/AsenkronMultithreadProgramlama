

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
 async  Task <string> ReadFile()
{
    StreamReader streamReader = new("Liste.txt");
    string content=await streamReader.ReadToEndAsync();  
    return content;
      
}
//readfile dosyasının ıcerıgını okuduk
string result = await ReadFile();
Console.WriteLine(result);

#endregion
