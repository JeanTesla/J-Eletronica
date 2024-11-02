using iText.Commons.Utils.Collections;
using iText.Kernel.Geom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEletronicaC_.helpers
{

    internal class FileHelper
    {
        public string fullPathConfigFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "config.conf");

        public static void createFile(string path, string fileName) {

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);

                File.Create(System.IO.Path.Combine(di.FullName, fileName)).Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public static List<string>? ReadConfigFile()
        {
            String line;
            List<string> configs = new List<string>();

            try
            {
                var fullPathConfigFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "config.conf");

                if (!File.Exists(fullPathConfigFile)) {
                    return null;
                }

                StreamReader sr = new StreamReader(fullPathConfigFile);
         
                line = sr.ReadLine();
             
                sr.Close();

                return line.Split(';').ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static void writeToConfigFile(string textConfig) {
            createFile(Directory.GetCurrentDirectory(), "config.conf");
            var fullPathConfigFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "config.conf");
            try
            {
                StreamWriter sw = new StreamWriter(fullPathConfigFile, false);
                sw.WriteLine(textConfig);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
