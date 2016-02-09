using System;
using System.IO;

/*
 * Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */

class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\Emil\Documents\Visual Studio 2013\Projects\ExceptionHandling\03.ReadFileContents\bin\Debug\test.txt"));
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine(@"path specified a file that is read-only.
                                    -or-
                                    This operation is not supported on the current platform.
                                    -or-
                                    path specified a directory.
                                    -or-
                                    The caller does not have the required permission.");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("path is null.");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("The file specified in path was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine(@"path is in an invalid format.
                                      SecurityException	
                                      The caller does not have the required permission.");
        }
    }
}