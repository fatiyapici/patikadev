namespace interfaces;

public class SmsLogger:ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Sms logged.");
    }
}