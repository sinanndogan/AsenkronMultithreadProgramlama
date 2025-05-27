

#region Thread Sınıfı
//class Program
//{
//    private static void Main(string[] args)
//    {
//        //thread oluşturma
//        Thread thread = new(() =>
//        {//Worker thread
//            for (int i = 0; i < 999; i++)
//            {
//                Console.WriteLine($"Worker Thread {i}");
//            }
//        });

//        thread.Start();   // Bir thread çalışabilmesi için Start edilmelidir.

//        for (int i = 0; i < 999; i++)
//        {// Main thread   //main thread start komutuna ihtiyaç duymamaktadır
//            Console.WriteLine($"Main Thread {i}");
//        }
//    }
//}
#endregion


#region Thread Id
// Her thread ıd birbirinden farklıdır 
// class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Main Thread");
//        Console.WriteLine(Environment.CurrentManagedThreadId);
//        Console.WriteLine(AppDomain.GetCurrentThreadId()); // kullanılmıyor deprecated bir yapı
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

//        Thread thread1 = new(() =>
//        {
//            Console.WriteLine("Worker Thread");
//            Console.WriteLine(Environment.CurrentManagedThreadId);
//            Console.WriteLine(AppDomain.GetCurrentThreadId());  // kullanılmıyor deprecated bir yapı
//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        });

//        thread1.Start();


//        Thread thread2 = new(() =>
//        {
//            Console.WriteLine("Worker Thread2");
//            Console.WriteLine(Environment.CurrentManagedThreadId);
//            Console.WriteLine(AppDomain.GetCurrentThreadId()); // kullanılmıyor deprecated bir yapı
//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        });

//        thread2.Start();
//    }
//}
#endregion


#region IsBackground
//eğer true olursa arkaplanda çalısan bir Thread
//eğer false olursa arkaplanda çalışmayan bir  Thread   default değer false
// class Program
//{
//    private static void Main(string[] args)
//    {
//        int i = 10;
//        Thread thread = new(()=>{
//            while (i>=0)
//            {
//                i--;
//                Thread.Sleep(100);  // Milisaniye
//            }
//            Console.WriteLine("Worker Thread görevini tamamladı");
//        });
//        //Değer true olduğu zaman main thread görevi tamamladıgı anda workerin bi önemi kalmaz
//        //Değer false olduğunda main thread işi tamamlasa dahi worker threadın tamamlamasını bekleyecektir.
//        thread.IsBackground = false;
//        thread.Start();
//        Console.WriteLine("Main Thread görevini tamamladı");

//    }
//}
#endregion


#region Thread State
//int a = 10;

//Thread thread = new(() =>
//{
//	while (a>= 0)
//	{
//		a--;
//		Thread.Sleep(1000);
//	}
//    Console.WriteLine("Worker Thread görevini yerine getirdi");
//});

//thread.Start();

////state kontrolu
//// öncelikle varsayılan bir state değerini alıyor daha sonra onun
////üzerinden karşılaştırma yapılmaktadır.
//ThreadState state = ThreadState.Running;

//while (true)
//{
//	if (thread.ThreadState == ThreadState.Stopped)
//		break;  //Thread state stop olunca döngüden cık

//	if(state != thread.ThreadState)  // state değeri elimdeki state değeri ile aynı değilse yazdır diyorum
//	{
//		state = thread.ThreadState;   // sürekli konsola yazdırmaması için
//        Console.WriteLine(state);
//	}
//}
//Console.WriteLine("Main thread görevini tamamladı");
#endregion

#region Race Conditional durum müdahaleleri
#region Locking   

// iki thredden biri işlemi tamamlıyor daha sonra diğeri işlemini yapıyor
//burda sistem isterse 2. thread isterse 1.thredden başlıyor
//object locking = new();

//int sayi = 1;

//Thread thread1 = new(() =>
//{
//    lock (locking)
//    {
//        while (sayi < 10)
//        {
//            sayi++;
//            Console.WriteLine($"Thread 1 : {sayi}");
//        }
//    }

//});


//Thread thread2 = new(() =>
//{
//    lock (locking)
//    {
//        while (sayi > 0)
//        {
//            sayi--;
//            Console.WriteLine($"Thread 2 : {sayi}");
//        }
//    }

//});
//thread1.Start();
//thread2.Start();

#endregion

#region join Metodu
//Bir thread'in başka bir threadin işleminin bitmesini beklemesi için kullanılan metottur

//Thread thread1 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread1-{i}");
//    }
//});

//Thread thread2 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread2-{i}");
//    }
//});
//thread1.Start();
//thread1.Join();
//thread2.Start();
#endregion
#endregion

#region Thread İptal Etme
//bool stop = false;
//Thread thread = new(() =>
//{
//	while (true)
//	{
//		if (stop) break;
//        Console.WriteLine("ada");
//	}
//    Console.WriteLine("Thread işlemi sona erdi");
//});
//thread.Start();
//Thread.Sleep(5000);
//stop = true;
#endregion

