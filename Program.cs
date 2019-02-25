using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;

namespace imagesharp_issue
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var image = Image.Load<Rgb24>(typeof(Program).Assembly.GetManifestResourceStream("imagesharp_issue.0.jpg")))
            {
                image.Mutate(x =>
                    x.Resize(128, 128));
            }

            Console.WriteLine("Hello World!");
        }
    }
}
