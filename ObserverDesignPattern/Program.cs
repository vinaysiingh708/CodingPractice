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
            // What is Observer Design Pattern ?
            //Establishes a one-to-many dependency between objects so that when one object changes state, all its dependents are notified.

            Video video = new Video("test");
            EmailService emailService = new EmailService();
            SMSService sMSService = new SMSService();

            video.onVideoUploaded += emailService.SendEmail;
            video.onVideoUploaded += sMSService.SendSMS;

            video.UploadVideo();
        }
    }
}
