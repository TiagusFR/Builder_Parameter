using Builder_Parameter;

public class MailService
{
    // Nested EmailBuilder class
    public class EmailBuilder
    {
        private readonly Email email;
        public EmailBuilder(Email email) => this.email = email;

        // Fluent members
        public EmailBuilder From(string from)
        {
            email.From = from;
            return this;
        }

        public EmailBuilder To(string to)
        {
            email.To = to;
            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            email.Subject = subject;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            email.Body = body;
            return this;
        }
    }


    private void SendEmailInternal(Email email)
    {

        Console.WriteLine($"Sending email to: {email.To}, subject: {email.Subject}, body: {email.Body}");
    }

    public void SendEmail(Action<EmailBuilder> builder)
    {
        var email = new Email();
        builder(new EmailBuilder(email));
        SendEmailInternal(email);
    }
}
