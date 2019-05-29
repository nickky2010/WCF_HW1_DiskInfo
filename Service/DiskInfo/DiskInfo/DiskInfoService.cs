using System.IO;
using System.Security;
using System;

namespace DiskInfo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DiskInfoService : IDiskInfoContract
    {
        public string[] GetDiskInfo(string path)
        {
            string[] pathInfo = null;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] folders = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                int countName = folders.Length + files.Length;
                if (countName > 0)
                {
                    pathInfo = new string[countName];
                    for (int i = 0; i < folders.Length; i++)
                    {
                        pathInfo[i] = folders[i].Name;
                    }
                    for (int j = 0, i = folders.Length; i < countName; i++, j++)
                    {
                        pathInfo[i] = files[j].Name;
                    }
                }
            }
            catch(SecurityException)
            {
                pathInfo = null;
            }
            catch (ArgumentNullException)
            {
                pathInfo = null;
            }
            catch (ArgumentException)
            {
                pathInfo = null;
            }
            catch (PathTooLongException)
            {
                pathInfo = null;
            }
            catch (DirectoryNotFoundException)
            {
                pathInfo = null;
            }
            catch (UnauthorizedAccessException)
            {
                pathInfo = null;
            }
            return pathInfo;
        }
    }
}
