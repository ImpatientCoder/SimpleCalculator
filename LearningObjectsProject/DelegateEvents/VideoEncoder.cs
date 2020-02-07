using System;
using System.Threading;

public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}


public class VideoEncoder
{
    //Define a delegate
    //Define an event based on that delegate
    //Raise the event

    public delegate void videoOncodedEventHandler(object source, VideoEventArgs args);
    public event videoOncodedEventHandler VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }
    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
        {
            VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

}
