using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{

    // The Observer Design Pattern in C# is a behavioral design pattern that defines a one-to-many relationship between objects.
    // When the state of one object (the subject) changes, all of its dependent objects (observers) are notified and updated automatically.
    public delegate void OnVideoUploaded();
    class Video
    {
        public OnVideoUploaded onVideoUploaded;
        public string Name { get; set; }

        public Video(string name)
        {
            Name = name;
        }

        public void UploadVideo()
        {
            Console.WriteLine("Uploading Video.");
            Thread.Sleep(1000);
            Console.WriteLine("Video Uploaded.");

            onVideoUploaded();
            Console.ReadLine();
        }
    }
}
