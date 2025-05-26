

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