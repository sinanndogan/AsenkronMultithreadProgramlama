//BU DERS İLE ASENKRON PROGRAMLAMAYA BAŞLADIK

#region Task sınıfı inceleme


#region TaskRun
//task.start dememize gerek yok 
//Task task = Task.Run(() =>
//{
//	for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//});
#endregion
#region Task.Factory.StartNew
//start yapılmasına gerek yok
Task task = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < 7; i++)

        Console.WriteLine(i);
});
#endregion
#region TaskWait

//tanımlandıgı yerde akışın senkron olmasını sağlamaktadır
//merhaba yukarıdaki task işlemlerinden önce veya ortasında da yazdırılabilir fakat  işlem gereği sonra yazılması için wait kullanılabiiilir
//task.Wait();
//Console.WriteLine("merhaba");
#endregion
#region ContinuneWith
//Bir task tamamlandıktan sonra belirli bir işlemi gerçekleştirmek için kullanılır
//bir event mantığında çalışma sergileyebiliyoruz.
//task.ContinueWith((_task) =>
//{

//    Console.WriteLine("Task 7 ye kadar saydıktan sonra yapıalcak işlem");
//});

#endregion
#region WaitAll
//verilen taskların tamamlanmasını bekler amacı belirtilen taskların tamamlanmasını bekler
//Task task2 = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < 7; i++)

//        Console.WriteLine(i);
//});
//Task task3 = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < 7; i++)

//        Console.WriteLine(i);
//});
//Task.WaitAll(task, task2, task3);
//Console.WriteLine("Belirtilen taskların işlemleri bitmiştir");
#endregion
#region WhenAll
//Belirtilen taskların işlemleri tamamlanınca bir TASK dönme işlemi sağlanmak istenince kullanır


Task task2 = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < 7; i++)

        Console.WriteLine(i);
});
Task task3 = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < 7; i++)

        Console.WriteLine(i);
});
//await keywördü bize yardımcı oluyor sonraki aşamalarda inceleyeceğiz
//await yazmadıgımız zaman proje çalışır fakat sonda yer alan mrb yazısı içeride ortada bir yerde gözüküyor olacaktır
 Task.WhenAll(task, task2, task3);
Console.WriteLine("mrb");
#endregion
#endregion


Console.Read();


