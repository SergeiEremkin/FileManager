using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager2._0
{
    class Program
    {
                          // Вывод директорий и файлов в консоль.
        public static void ShowDirsAndFiles()
        {
            Console.WriteLine("Введите путь: ");
            string path = Console.ReadLine();
            var dir = Directory.GetDirectories(path); 
            var file = Directory.GetFiles(path);
            
            
            //int PageCount = dir.Length/Page; 
            Console.WriteLine($"{dir.Length}  {file.Length}");


            if (Directory.Exists(path))
            {


                for (int i = 0; i < dir.Length; i++)
                {
                    Console.WriteLine(dir[i]);
                }
                
               
            }
           
            if (Directory.Exists(path))
                Console.WriteLine("------");
            {
                    for (int j = 0; j <file.Length; j++)
                    {

                        Console.WriteLine($" - {file[j]}");

                    }
                }
               

        }
        // Функция копирования файла
        
        public static void CopyFile()
        {
            {
                Console.WriteLine("Откуда копируем?");
                string from = Console.ReadLine();
                Console.WriteLine("Куда копируем?");
                string to = Console.ReadLine();
                File.Copy(from, to);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Файл скопирован");
                Console.ResetColor();
            }
        }
        // Функция удаления файла
        public static void DeleteFile()
        {
            Console.WriteLine("Введите путь и название файла");
            string path = Console.ReadLine();
            File.Delete(path);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Файл удален");
            Console.ResetColor();
        }

        // Инфо о директории
        public static void DirectoryInfo(string path)
        {
            
            DirectoryInfo info = new DirectoryInfo(path);
            Console.WriteLine($"Путь: {info.FullName}");
            Console.WriteLine($"Диск: {info.Root}");
            Console.WriteLine($"Последнее взаимодействие: {info.LastAccessTime}");
            Console.WriteLine($"Дата создания: {info.CreationTime}");
            Console.WriteLine($"Атрибуты: {info.Attributes}");
            
        }
               //Инфо о файле
        public static void FileInfo (string path)
        {
            FileInfo info = new FileInfo(path);
            Console.WriteLine($"Имя: {info.Name}");
            Console.WriteLine($"Путь: {info.DirectoryName}");
            Console.WriteLine($"Последнее взаимодействие: {info.LastAccessTime}");
            Console.WriteLine($"Дата создания: {info.CreationTime}");
            Console.WriteLine($"Размер: {info.Length}");
            Console.WriteLine($"Расширение: {info.Extension}");
            Console.WriteLine($"Атрибуты: {info.Attributes}");


        }


        static void Main(string[] args)
        {
           
            Console.WriteLine("Добро пожаловать в программу FileManager!");
            Console.WriteLine();
            Console.WriteLine("Напечатайте 'help' чтобы узнать как пользоваться программой");
           
            Console.WriteLine();
            var origWidth = Console.WindowWidth;
            var origHight = Console.WindowHeight;
           
            while (true)
            {

                try
                {
                    string UserChoise = Console.ReadLine();



                    for (int i = 0; i < 1; i++)
                    {

                        switch (UserChoise)
                        {
                            case "help":
                                Console.Clear();
                                Console.WriteLine("Напечатайте 'dir' для отображения папок и каталогов");
                                Console.WriteLine("Напечатайте 'copy' для копирования файла из одной папки в другую");
                                Console.WriteLine("Напечатайте 'delete' для удаления файла");
                                Console.WriteLine("Напечатайте 'infoD' для отображения информации по директрии");
                                Console.WriteLine("Напечатайте 'infoF' для отображения информации по файлу");
                                break;

                            case "dir":
                                Console.Clear();
                                
                                ShowDirsAndFiles();
                                
                                
                                break;

                            case "copy":
                                Console.SetCursorPosition(0, 29);
                                CopyFile();
                                    break;

                            case "delete":
                                Console.SetCursorPosition(0, 29);
                                DeleteFile();
                                break;

                            case "infoD":
                                Console.SetCursorPosition(0, 29);
                                Console.WriteLine("Введите путь: ");
                                DirectoryInfo(Console.ReadLine());
                                break;

                            case "infoF":
                                Console.SetCursorPosition(0, 29);
                                Console.WriteLine("Введите путь: ");
                                FileInfo(Console.ReadLine());
                                break;
                             
                        }
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

    }
}          

        
    

