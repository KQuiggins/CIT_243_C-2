using static System.Console;
using System.Threading.Tasks;
using FluentEmail.Smtp;
using FluentEmail.Core;
using FluentEmail.Razor;
using System.Net.Mail;
using System.Text;


namespace SendingEmails
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new SmtpSender(() => new SmtpClient(host: "localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 25
                //DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                //PickupDirectoryLocation = @"c:\tempMail"

            });

            StringBuilder template = new();
            template.AppendLine(value:"Dear @Model.FirstName, ");
            template.AppendLine(value:"<p>Thanks for purchasing @Model.ProductName. We hope you enjoy it.</p>");
            template.AppendLine(value:"Kens tech support");

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            var email = await Email
                .From(emailAddress: "ken@ken.com")
                .To(emailAddress: "test@test.com", name: "Test")
                .Subject("Test")
                .UsingTemplate(template.ToString(), new { FirstName = "Ken", ProductName = "Alienware R10 Ryzen Edition" })
                //.Body("This is a test email")
                .SendAsync();
            
        }
        
    }
}