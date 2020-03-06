using System;
using System.ComponentModel;
using System.Linq;

namespace Course_proj_KMP_serch
{
    /// <summary>
    /// Класс_1 для реализации компонента Controller
    /// </summary>
    public class SolutionKernel
    {
        /// <summary>
        /// Поле для формы, с которой работает пользователь
        /// </summary>
        Interface_prog mainForm;
        
        /// <summary>
        /// Конструктор с параметром - форма, с которой работает пользователь
        /// </summary>
        /// <param name="_form"></param>
        public SolutionKernel(Interface_prog _form)
        {
            mainForm = _form; // инициализируем поле класа для формы
        }

        /// <summary>
        /// Метод, который выполняет поиск и вызывается из нового потока
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] SearchSubstr(DoWorkEventArgs e)
        {
            try
            {
                string[] allLines = ((ParamsForNewThread)e.Argument).text; // получаем текст
                string _subStr = ((ParamsForNewThread)e.Argument).substr; // получаем образец
                int offset = 0; // кол-во символов от начало к первому вхождению образца 
                int countLines = allLines.Count(); // получ. кол-во строк
                int resSearching; // для хранения результата поиска
                KMP_Search progLogic = new KMP_Search(ref _subStr); // создаем экземпляр класса для поиска

                for (int i = 0; i < countLines; i++) // проходим по все линиям
                {
                    if (allLines[i].Length < _subStr.Length) // если длина подстроки больше строка, то сразу пропускаем
                    {
                        if (i < countLines - 1) // если не последняя линия то добавляем длину строки к offset
                        {
                            offset += allLines[i].Count();
                        }
                        continue; // на след. строку переходим
                    }
                    progLogic.String = allLines[i]; // передаем в класс для поиска строку

                    resSearching = progLogic.KMPSearch(); // вызываем метод для поиска

                    if (resSearching == -2) // если результат -2, то исключение
                    {
                        throw new Exception("Ошибка при поиске подстроки в строке");
                    }
                    else if (resSearching != -1) // если не равно -1, то нашли вхождение и
                    {                            // возв. строку, позицию, и кол-во пройденых символов
                        return new int[] { i, resSearching, offset + i - 1 };
                    }
                    if (i < countLines - 1) // если еще не все линии пройшли
                    {                       // то добавляем длину строки к offset
                        offset += allLines[i].ToCharArray().Length;
                    }
                }
                return new int[] { -1 }; // если прошли по всем линиям и не найшли вхождение
            }
            catch (Exception) // обрабатуем исключительную ситуацию
            {                 // в этом случаем возв. -2
                return new int[] { -2 };
            }
        }

        /// <summary>
        /// Метод для блокировки кнопок, которые могут изменить значение текста
        /// </summary>
        public void BlockAllButtons()
        {
            mainForm.buttonReadFromFIle.Enabled = false;
            mainForm.buttonSaveInFile.Enabled = false;
            mainForm.buttonSearch.Enabled = false;
            mainForm.buttonUndo.Enabled = false;
            mainForm.buttonRedo.Enabled = false;
        }

        /// <summary>
        /// Метод для розблокировки кнопок, которые могут изменить значение текста
        /// </summary>
        public void UnblockAllButtons()
        {
            mainForm.buttonReadFromFIle.Enabled = true;
            mainForm.buttonSaveInFile.Enabled = true;
            mainForm.buttonSearch.Enabled = true;
            mainForm.buttonUndo.Enabled = true;
            mainForm.buttonRedo.Enabled = true;
        }

        /// <summary>
        /// Проверка на то есть ли видимые символы в двумерном массив
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public bool IsEmptyBox(string[] lines)
        {
            int count; // кол-во символом
            // с помощью LINQ считаем кол-во строк с видимыми элементами 
            count = lines.Count(s => !string.IsNullOrWhiteSpace(s));  
            return count == 0 ? true : false; // если есть строки с видимыми, то возв. false, иначе true
        }

        /// <summary>
        /// Метод для сохранения текста из элемента для ввода текста в файл
        /// </summary>
        /// <param name="_fname"></param>
        public void SaveTextInFile(string _fname)
        {
            string fName = _fname;
            FileLogic fileLogic = new FileLogic(); // класс для работы с файлами
            // вызываем метод для сохранения и получаем результат сохранения
            string resSaving = fileLogic.SaveInFile(mainForm.richTextBoxText.Lines, ref fName); 
            if (resSaving != null) // если результат не равен null, значит сохранение не удачно
                throw new Exception(resSaving); // генерируем исключение
        }

        /// <summary>
        /// Метод для считывани текста из файла в элемент для хранения текста
        /// </summary>
        /// <param name="fname"></param>
        public void ReadAllFileLines(string fname)
        {
            FileLogic fileLogic = new FileLogic(); // класс для работы с файлами
            // вызываем метод для считывания текста
            string[] statusOfReading = fileLogic.OpenFile(fname);
            if (statusOfReading == null) // если результат равен null, то считывание не удачно
                throw new Exception("Ошибка при чтении файла"); // генерируем исключение
            else // если все удачно, то присв. считаный текст в элемент формы
                mainForm.richTextBoxText.Lines = statusOfReading;
        }

        /// <summary>
        /// Для установки динамиеских  подсказок для элементов формы
        /// </summary>
        public void SetToolTipParams()
        {
            mainForm.toolTip.SetToolTip(mainForm.labelTextInput, "Поле для хранения текста, в котором будет происходить поиск");
            mainForm.toolTip.SetToolTip(mainForm.labelSubStrInput, "Поле для хранения текста, которым небходимо найти");
            mainForm.buttonReadFromFIle.ToolTipText = "Наймите для ввода текста для поиска из файла формата .txt";
            mainForm.buttonSaveInFile.ToolTipText = "Нажмите для сохранения введенного текста, в котором происходит поиск, в файл формате .txt";
            mainForm.toolTip.SetToolTip(mainForm.buttonSearch, "Нажмите для начала поиска образца в тексте");
            mainForm.buttonHelp.ToolTipText = "Для получения информации о программе";
            mainForm.buttonUndo.ToolTipText = "Отменить последний шаг (undo)";
            mainForm.buttonRedo.ToolTipText = "Вернуть последний шаг (redo)";
            mainForm.toolTip.SetToolTip(mainForm.labelStaticInPosition, "Индекс вхождения подстроки в строку");
            mainForm.toolTip.SetToolTip(mainForm.labelStaticInStr, "Номер строки, в которой был найден образец");
        }
    }
}
