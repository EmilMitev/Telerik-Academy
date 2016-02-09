using System;
using System.Net;

/*
 * Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
 */

class DownloadFile
{
    static void Main()
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("http://p1.pichost.me/i/45/1685114.jpg", "1685114.jpg");
            }
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine(@"The address parameter is null.
                                      -or-
                                      The fileName parameter is null.");
        }
        catch (WebException)
        {
            Console.Error.WriteLine(@"The URI formed by combining BaseAddress and address is invalid.
                                      -or-
                                      filename is null or Empty.
                                      -or-
                                      The file does not exist.
                                      -or-
                                      An error occurred while downloading data.");

        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}