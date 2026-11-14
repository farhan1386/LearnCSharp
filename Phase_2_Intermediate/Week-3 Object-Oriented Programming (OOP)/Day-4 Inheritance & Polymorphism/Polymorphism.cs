using System;
using System.Collections.Generic;

namespace Phase_2_Intermediate.Week_3_Object_Oriented_Programming
{
    public class Polymorphism
    {
        public static void Run()
        {
            // Creating a polymorphic collection of Media assets
            List<MediaFile> userPlaylist = new List<MediaFile>()
            {
                new VideoFile { Title = "C# OOP Tutorial", VideoResolution = "1080p" },
                new AudioFile { Title = "Lo-Fi Beats for Coding", BitrateKbps = 320 }
            };

            Console.WriteLine("--- Starting Media Playlist --- \n");

            // POLYMORPHISM IN ACTION:
            // One interface call (.Play()) triggers entirely different actions at runtime.
            foreach (var media in userPlaylist)
            {
                media.Play();
                Console.WriteLine(); // Spacing
            }

            Console.ReadLine();
        }
    }

    // BASE CLASS
    public class MediaFile
    {
        public string Title { get; set; } = string.Empty;

        // 'virtual' tells C# that child classes are expected to change this behavior
        public virtual void Play()
        {
            Console.WriteLine($"[Media System] Opening generic media link for: {Title}");
        }
    }

    // DERIVED CLASS 1: Video Implementation
    public class VideoFile : MediaFile
    {
        public string VideoResolution { get; set; } = string.Empty;

        // 'override' replaces the base method completely for Video context
        public override void Play()
        {
            Console.WriteLine("[Video Engine] Initializing hardware decoding pipeline...");
            Console.WriteLine($"[Playing Video] \"{Title}\" rendering smoothly at {VideoResolution}.");
        }
    }

    // DERIVED CLASS 2: Audio Implementation
    public class AudioFile : MediaFile
    {
        public int BitrateKbps { get; set; }

        // 'override' replaces the base method completely for Audio context
        public override void Play()
        {
            Console.WriteLine("[Audio Engine] Buffering clean audio stream track...");
            Console.WriteLine($"[Playing Audio] \"{Title}\" streaming crisp output at {BitrateKbps} kbps.");
        }
    }
}