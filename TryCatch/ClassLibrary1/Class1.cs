using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ReadFileContent(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    return "File not found";
                }
            } catch (Exception ex) 
            { 
                return ex.Message;
            }
        }
    }
}
