using System;
using System.IO;

namespace Exercise6
{
    public class TryFileParser
    {
        public static void TryParse(string pathFile)
        {
            try
            {
                StreamReader readerFile = new StreamReader(pathFile);
                using (readerFile)
                {
                    int lineNumberFile = 0;
                    string lineFile = null;
                    while ((lineFile = readerFile.ReadLine()) != null)
                    {
                        try
                        {
                            float.Parse(lineFile);
                        }
                        catch (Exception e)
                        {
                            throw new FileParseException(pathFile, lineNumberFile, e);
                        }

                        lineNumberFile++;
                    }
                }
            }
            catch (IOException e)
            {
                throw new FileParseException(pathFile, e);
            }
        }
    }
}
