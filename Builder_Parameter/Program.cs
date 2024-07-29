using System;

namespace Builder_Parameter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mailService = new MailService();
            mailService.SendEmail(builder =>
            {
                builder.From("sender@microsoft.com")
                .To("receiver@microsoft.com")
                .Subject("Subject")
                .Body("Hello world");
            });
        }
    }
}