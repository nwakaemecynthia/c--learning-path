using System.IO;

namespace Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /***********************************************************************************************************************************
                SYSTEM.IO
                We will be looking at:

                1) File, FileInfo: Provides methods for creating, copying, deleting, moving and opening files
                    *) FileInfo: provides `instance` methods (more efficient as security checks are only done whine you instantiate the class and not at every use)
                    *) File: provides `static` methods (usually for small methods, as security checks are done at every use)
                    ******************************************************
                    EXAMPLE
                    ******************************************************
                       a) Create()
                       b) Copy()
                       c) Delete()
                       d) Exists()
                       e) GetAttributes()
                       f) Move()
                       g) ReadAllText()


                2) Directory, DirectoryInfo: very similar to `File` and `FileInfo`, i.e; Provides methods for creating, copying, deleting, moving and opening directories
                    *) DirectoryInfo: provides `instance` methods (more efficient as security checks are only done whine you instantiate the class and not at every use)
                    *) Directory: provides `static` methods (usually for small methods, as security checks are done at every use)
                     ******************************************************
                    EXAMPLE
                    ******************************************************
                       a) CreateDirectory()
                       b) Delete()
                       c) Exists()
                       d) GetCurrentDirectory()
                       e) GetFiles()
                       f) Move()
                       g) GeLogicalDrives()

                3) Path:
                 ******************************************************
                    EXAMPLE
                ******************************************************
                       a) GetDirectoryName()
                       b) GetFileName()
                       c) GetExtension()
                       d) GetTempPath()
            ******************************************************************************************************************************************/

            /* FILE AND FILEINFO*/
            var path = @"/Users/cynthianwakaeme/Public/UnLearning";
            var path1 = @"/Users/cynthianwakaeme/Public/truQ/Documentation-templates/Html/gulpfile.js";
            var path2 = @"/Users/cynthianwakaeme/Public/Learning/c#/beginner";
            File.Copy(@"/Users/cynthianwakaeme/Public/Learning/test.png", @"/Users/cynthianwakaeme/Public/Learning/yodella.png", true);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File cannot be found");
            }

            var content = File.ReadAllText(path1);
            System.Console.WriteLine(content);

            var fileInfo = new FileInfo(path1);



            if (fileInfo.Exists)
            {
                // fileInfo.CopyTo("...");
                // fileInfo.Delete("...");
                // fileInfo.OpenRead();

            }
            else
            {
                Console.WriteLine("File cannot be found again");
            }



            /* DIRECTORY AND DIRECTORYINFO*/
            // Directory.CreateDirectory(@"/Users/cynthianwakaeme/Public/UnLearning");

            // var files = Directory.GetFiles(path2", "*.*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(@"/Users/cynthianwakaeme/Public/Learning/c#", "*.cs", SearchOption.AllDirectories);

            // foreach (var file in files){
            //     Console.WriteLine(file);
            // }

            var directories = Directory.GetDirectories(path2, "*.*", SearchOption.AllDirectories);
            // foreach (var directory in directories)
            // {
            //     Console.WriteLine(directory);
            // }

            // var directoryInfo = new DirectoryInfo(path2);
            // directoryInfo.GetFiles();
            // directoryInfo.GetDirectories();


            /* PATH */
            var pathExample = @"/Users/cynthianwakaeme/Public/Learning/c#/c#.sln";
            var dotIndex = pathExample.IndexOf('.');
            var extention = pathExample.Substring(dotIndex);
            System.Console.WriteLine("Dot index: "  + dotIndex + " and the extention is: " + extention);

            //INSTEAD OF THE ABOVE, DO THIS.
            System.Console.WriteLine("The path to `pathExample` is: " + Path.GetExtension(pathExample));
            System.Console.WriteLine("The file name to `pathExample` is: " + Path.GetFileName(pathExample));
            // System.Console.WriteLine("The file name without extension to `pathExample` is: " + Path.GetFileNameWithouExtension(pathExample));
            System.Console.WriteLine("The Directory name to `pathExample` is: " + Path.GetDirectoryName(pathExample));


            Test.FileCount(path1);
            Test.MaxLengthText(path1);

        }

    }
}