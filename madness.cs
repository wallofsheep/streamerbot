 
//Written by Riverside -- Enjoy The Living Arcade!
//NOTE: Must include a reference to system.dll within streamer.bot

using System;
using System.Diagnostics;
using System.ComponentModel;
public class CPHInline
{
	public bool Execute()
	{
		// your main code goes here
		

            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // Sart process
                    myProcess.StartInfo.FileName = "c:\\vpin\\ten2midnight.exe"; // Change path and exe. must have \\ for paths.
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself.
                    // Given that it is started without a window so you cannot terminate it
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
		
		
		return true;
	}
}