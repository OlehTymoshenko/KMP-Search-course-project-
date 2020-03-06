using System;
using System.Linq;
using System.IO;

namespace Course_proj_KMP_serch
{
    /// <summary>
    /// Класс для реализации работы с файлами
    /// </summary>
    public class FileLogic
    {
        /// <summary>
        /// Метод для считывания данных из файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string[] OpenFile(string fileName)
        {
            try
            {
                string[] allFileLines; // объявляем массив для хранения все данных
                using (FileStream fs = File.OpenRead(fileName)) // открываем поток по имени файла
                {
                    using (BufferedStream bs = new BufferedStream(fs)) // открываем буфферизированный
                    {                                                  // поток на основе обычного
                        using (StreamReader sr = new StreamReader(bs)) // создаем StreamReader для чтения из потока
                        {
                            string tmpStr = ""; // строка для считывани у нее всего потока
                            tmpStr = sr.ReadToEnd(); // считуем весь поток в строку
                            int j = tmpStr.Count(c => c == '\n'); // считаем кол-во строк
                            bs.Position = 0; // возв. позицию в потоке начало
                            allFileLines = new string[j]; // создаем этот массив размером равеным кол-ву строк
                            j = 0; // обнуляем j, и теперь он будет служить индексом массива 
                            while (!sr.EndOfStream) // пока не дошли к концу потока
                                allFileLines[j++] = sr.ReadLine(); // считываем строку и записуем в массив
                        }
                    }
                }
                return allFileLines; // возв. считанные данные
            }
            catch (Exception) // обрабатуем возможную исключительную ситуацию
            { 
                return null; // возв. null
            }
        }

        /// <summary>
        /// Метод для считывания сохранения данных в файл
        /// </summary>
        /// <param name="strsForSave"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string SaveInFile(string[] strsForSave, ref string fileName)
        {
            try
            {
                using (FileStream fs = File.OpenWrite(fileName)) // открываем поток по имени файла
                {
                    using (BufferedStream bs = new BufferedStream(fs)) // открываем буфферизированный
                    {                                                  // поток на основе обычного
                        using (StreamWriter sw = new StreamWriter(bs)) // создаем StreamReader для чтения из потока
                        {
                            foreach(string str in strsForSave) // проходим по всем строкам для сохранения 
                            {
                                sw.WriteLine(str); // записуем текущюю строку в буфер
                            }
                            sw.Flush(); // выталкиваем все данные из буфера в файл
                        }
                    }
                }
                return null; // возв. null в случае успешного сохранения
            } 
            catch(Exception ex) // обрабатуем возможную исключительную ситуацию
            {
                return ex.Message; // возв. описание ошибки 
            }
        }
    }
}
