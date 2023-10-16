using System.Drawing;
using System.Net.Mail;
using System.Net;

namespace Web_24BM.Services
{
    public interface IEmailSenderService
    {
        bool SendEmail(string email);
    }
}
