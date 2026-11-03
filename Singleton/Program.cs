using Singleton.Start;

internal class Program
{
    static MemoryLogger logger;

    private static void Main(string[] args)
    {
        logger = MemoryLogger.Instance;

        Console.WriteLine("Hello, World!");
        AssignVoucher("user@example.com", "Voucher123");
        SendEmail("user@example.com", "Voucher123");
        logger.PrintLogSummary();
        Console.ReadKey();
    }
    private static void AssignVoucher(string email,string voucher)
    {
        logger = MemoryLogger.Instance;
        logger.LogInfo($"Assigning voucher {voucher} to user {email}"); 
        logger.LogWarning($"Voucher {voucher} is about to expire for user {email}");
    }
  private static void SendEmail(string email, string voucher)
    {
        logger = MemoryLogger.Instance;
        logger.LogInfo($"Sending email to {email} with voucher {voucher}");
    }
}