using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Labb2___Bildtjanster_i_Azure_AI;

using System.Diagnostics;
using System.Reflection;

class Program
{
    private static bool exit = false;
    static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\images"; //path to images folder.

    static void Main(string[] args)
    {
        do
        {
            Menu();
        }while(exit == false);
    }
   
    static void Menu()
    {
        Console.WriteLine("Please enter the one of the following options:\n your image name like: ImageName.jpg \n open folder -- to open the image folder and add some picture");
        string input = Console.ReadLine();
        if(input.ToLower() == "open folder")
        {
            Process.Start("explorer.exe", path);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            string image = "images/" + input;
            PictureRecognition.PictureConfiqure(image);
            do
            {
                PictureRecognition.ImageMenu(image);

            }
            while (PictureRecognition.ImgMenu == true);
            
        }

    }
   

}
