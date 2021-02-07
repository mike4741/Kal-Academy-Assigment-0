using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{
    class IOFileStreams
    {
        string pathSource;
        string pathNew;
        string pathSource1;
        string pathNew1;

        public IOFileStreams(string sourse, string destination)
        {
            this.pathSource = sourse;
            this.pathNew = destination;
            //string pathSource = @"c:\tests\source.txt";
            //        string pathNew = @"c:\tests\newfile.txt";
        }
        // Specify a file to read from and to create.

        public void readFile()
        {


            try
            {

                using (FileStream fsSource = new FileStream(pathSource,
                    FileMode.Open, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(pathNew,
                        FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }
        public void ReadFilesys()
        {
            try
            {
                using (FileStream fs = new FileStream(pathNew1, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[fs.Length];
                    int bytestoread = (int)fs.Length;
                    int byteread = 0;

                    while(bytestoread>0)
                    {

                    }

                }
            }
            catch(FileNotFoundException ioEX2)
            {
                Console.WriteLine(ioEX2.Message);
            }
     
        }
    }
}
