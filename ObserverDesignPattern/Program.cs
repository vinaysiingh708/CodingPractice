using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("test");
            EmailService emailService = new EmailService();
            SMSService sMSService = new SMSService();

            video.onVideoUploaded += emailService.SendEmail;
            video.onVideoUploaded += sMSService.SendSMS;

            video.UploadVideo();
        }
    }
}
