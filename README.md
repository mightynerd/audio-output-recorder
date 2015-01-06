audio-output-recorder
=====================

A program written in C# with .NET 4.5 that records "what you hear" from any audio output device to a file. It uses NAudio for audio capture and ffmpeg for converting and downsampling to 44,1kHz 16bit WAV, MP3 and OGG. Capture can be done from any audio devices supported by Windows (including dedicated soundcards and USB-headseds). The program is meant to be easy to use and to look well on High-DPI displays.

##Screenshot
![Screenshot](http://i.imgur.com/QELmVHx.png)

##Compiling
Clone the repository, build it using Visual Studio 2013 (Community edition is used for development) and put a Windows binary of ffmpeg compiled with support for libmp3lame and libogg that you can acquire here: http://ffmpeg.zeranoe.com/builds/ in the same directory as the main excecutable. I will provide a download link for the binaries soon.
