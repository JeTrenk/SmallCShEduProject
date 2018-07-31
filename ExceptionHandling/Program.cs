using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;

            try
            {
                //code to execute
                //StreamReader works with files
                sr = new StreamReader(@"H:\My Documents\Jelena\GIT.txt");
                var content = sr.ReadToEnd();
            }
            catch(Exception)
            {
                //catch exception, start with the most specific one
            }
            finally
            {
                //deallocate all references that are not manage by garbage collector
                //f.e. database connections, working with files etc..
                if(sr!=null) sr.Dispose();
                //this is extremly important because we don't want to keep files open on the disk, connections and so on
            }

            ////or..........

            using (StreamReader sr1 = new StreamReader(@"H:\My Documents\Jelena\GIT.txt"))
            {
                var content = sr1.ReadToEnd(); //automatically creates finally bliock
            }
        }
    }
}
