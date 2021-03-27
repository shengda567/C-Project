using System;
using System.IO;

namespace ShengdaConsoleApplication
{
    public class PersonInfo
    {
        string FirstName;
        string LastName;

        public PersonInfo(String FName, String LName)
        {
            FirstName = FName;
            LastName = LName;
        }

        public void PresentToScreen()
        {
            Console.WriteLine(this.FirstName + this.LastName);
        }

        public void WriteToTextFile()
        {
            string writeText = $"First Name is : {this.FirstName}, Last Name is {this.LastName}";
            File.WriteAllText("FirstName_LastName_Information.txt", writeText);
        }

        public void ReadTextToScreen()
        {
            string readText = File.ReadAllText("FirstName_LastName_Information.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }
    }
}
