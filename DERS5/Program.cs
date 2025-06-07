#region ContinueWhenAll

//Tüm tasklar bittikten sonra çalışacak bir task asenkron şekilde devreye girecektir

Task task1 = Task.Run(() =>
{
    Console.WriteLine("Task 1 işlemi");
});

Task task2 = Task.Run(() =>
{
    Console.WriteLine("Task 2 işlemi");
});

Task task3 = Task.Run(() =>
{
    Console.WriteLine("Task 3 işlemi");
});

//yukarıda yer alan 3 task işlemini tamamlayınca aşağıdaki task çalışsın diyeceğiz
//bu işlemide taskFactoryWhenAll ile yapacagız  bu işlemide tüm taskları bir dizide toplayıp yapacagız

Task[] tasks = new[] { task1, task2, task3 };




TaskFactory factory = new();
 factory.ContinueWhenAll(tasks, (completedTask) =>
{
    //task1,task2,task3 tamamlandıktan sonra yapıalcak asenkron işlem burada tanımlanmaktadır
    Console.WriteLine("Tüm tasklar tamamlandıktan sonra çalışan yapı");
});
#endregion

#region ContiuneWhenAny
Task task4 = Task.Run(() =>
{
    Console.WriteLine("Task 4 işlemi");
});

Task task5 = Task.Run(() =>
{
    Console.WriteLine("Task 5 işlemi");
});

Task task6 = Task.Run(() =>
{
    Console.WriteLine("Task 6 işlemi");
});

Task[] tasks2 = new[] { task4, task5, task6 };

TaskFactory factory2 = new();
factory2.ContinueWhenAll(tasks2, (completedTask) =>
{
    //task1,task2,task3 lerden herhangi biri tamamlandıktan sonra  asenkron işlem burada tanımlanmaktadır
    Console.WriteLine("Herhangi bir task tamamlandıktan sonra çalışan yapı");
});
#endregion

Console.ReadLine();