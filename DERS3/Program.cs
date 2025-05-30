
#region Monitor.Enter ve Monitor.Exit

object locking = new();
int i = 0;

Thread thread1 = new(() =>
{
	try
	{
		//locking mekanizmasını devreye alır
		Monitor.Enter(locking);
		for (int i = 0; i < 10; i++)
		{
            Console.WriteLine($"Thread 1 {i}");
		}
	}
	finally
	{
		//locking mekanizmasını devreden çıkarır
		Monitor.Exit(locking);
	}
});

Thread thread2 = new(() =>
{
    try
    {
        //locking mekanizmasını devreye alır
        Monitor.Enter(locking);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Thread 2 {i}");
        }
    }
    finally
    {
        //locking mekanizmasını devreden çıkarır
        Monitor.Exit(locking);
    }
});

thread1.Start();
thread2.Start();
#endregion



#region Monitor.TryEnter Metodu
object lockingobject = new();
int b = 0;

Thread thread3 = new(() =>
{
    var result = Monitor.TryEnter(lockingobject, 50);
    if (result)
    {
		try
		{
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread 3 {i}");
            }
        }
		finally
        {
            Monitor.Exit(lockingobject);
        }
    }
});

Thread thread4 = new(() =>
{
    var result = Monitor.TryEnter(lockingobject, 50);
    if (result)
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread 4 {i}");
            }
        }
        finally
        {
            Monitor.Exit(lockingobject);
        }
    }
});

thread3.Start();
thread4.Start();
#endregion