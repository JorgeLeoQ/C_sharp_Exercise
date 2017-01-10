using System;
using System.Net;

namespace Exercise7
{
        public class DownloadFile
        {
            public static void Download(string url)
            {
                WebClient webClient = null;
                Uri ur = new Uri(url);
                string fileName = System.IO.Path.GetFileName(ur.LocalPath);

                try
                {
                    webClient = new WebClient();
                    webClient.DownloadFile(url, fileName);
                }
                catch (ArgumentException e)
                {
                    throw new DownloadFromInternetException(e, e.Message);
                }
                catch (NotSupportedException e)
                {
                    throw new DownloadFromInternetException(e, e.Message);
                }
                catch (WebException e)
                {
                    throw new DownloadFromInternetException(e, e.Message);
                }
                catch (Exception e)
                {
                    throw new DownloadFromInternetException(e, e.Message);
                }
                finally
                {
                    webClient.Dispose();
                }
            }

        }
    }
