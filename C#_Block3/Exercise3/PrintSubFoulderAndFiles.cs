using System;
using System.IO;
using System.Collections.Generic;

namespace Exercise3
{
    public class PrintSubFoulderAndFiles
    {
        public static string [] TraverseFoulder(string path)
        {
            List<string> elements = new List<string>();

            try
            {

                foreach (string file in Directory.GetFiles(path))
                {
                    elements.Add(file);
                }
                //ricorsione
                foreach (string directory in Directory.GetDirectories(path))
                {
                    elements.Add(directory + "\\");
                    elements.AddRange(TraverseFoulder(directory));
                }

            }
            catch(UnauthorizedAccessException uae)
            {
                throw new UnauthorizedAccessException(uae.Message);
            }

            return elements.ToArray();
        }
    }
}
