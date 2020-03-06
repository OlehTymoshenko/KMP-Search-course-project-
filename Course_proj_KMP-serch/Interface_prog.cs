using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Course_proj_KMP_serch
{
    /// <summary>
    /// Структура для передачи параметров новый поток
    /// </summary>
    public struct ParamsForNewThread
    {
        /// <summary>
        /// Конструктор структуры 
        /// </summary>
        /// <param name="_text"></param>
        /// <param name="_substr"></param>
        public ParamsForNewThread(string[] _text, string _substr)
        {
            text = _text; // инициализируем текст
            substr = _substr; // инициализируем обзразец
        }

        public string[] text; // поле для текста
        public string substr; // поле для образца
    }

    /// <summary>
    /// Класс для реализации компонента View
    /// </summary>
    public partial class Interface_prog : Form
    {
        /// <summary>
        /// Поле для класса реализующего Controller (логику программы)
        /// </summary>
        SolutionKernel solKernel;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Interface_prog()
        {
            InitializeComponent(); // инициализируем элементы формы
            solKernel = new SolutionKernel(this); // создаем экземпляр класса для релазиации логики
            solKernel.SetToolTipParams(); // устанавливаем в активное состояние динамические подсказки
        }

        /// <summary>
        /// Обработчик нажатия на кнопку считывания из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReadFromFIle_Click(object sender, EventArgs e)
        {
            // Вызываем метод этого класса для считывания
            ReadAllFileLines(); 
        }

        /// <summary>
        /// Обработчик нажатия на кнопку сохранения в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            // Проверка на то, есть ли данные для сохранения
            if (solKernel.IsEmptyBox(richTextBoxText.Lines))
            { // если нет устанавливаем ошибку
                errorProvider.SetError(richTextBoxText, "Введите текст для сохранения");
                return;
            }
            // если есть, то вызываем метод для сохранения 
            SaveTextInFile(); 
        }

        /// <summary>
        /// Обработчик нажатия на кнопку Поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bool resCheck = false; // переменная для проверки заполнены ли все необходимые поля
                if (solKernel.IsEmptyBox(textBoxSubsrting.Lines))
                { // проверка для текста 
                    errorProvider.SetError(textBoxSubsrting, "Введите строку, которую необходимо найти");
                    resCheck = true;
                }
                if (solKernel.IsEmptyBox(richTextBoxText.Lines))
                { // проверка для образца
                    errorProvider.SetError(richTextBoxText, "Введите текст, в котором будет проводится поиск");
                    resCheck = true;
                }
                if (resCheck == true) // если нет значения хотя бы в одном поле, то прерываем метод для поиска 
                    return;
                solKernel.BlockAllButtons(); // блокируем все клавиши , которые могут повлиять на текст
                // Создаем структуру с данными небоходимыми для нового потока
                ParamsForNewThread _params = new ParamsForNewThread(richTextBoxText.Lines, textBoxSubsrting.Text);
                BGW.RunWorkerAsync(_params); // создаем новый поток (вызывем асинхронный метод)
            }
            catch (Exception ex) // если случилось исключение
            {
                solKernel.UnblockAllButtons(); // разблокируем все кнопки и выведем сообщение об ошибке
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Обработчик для кнопки Справка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(); // создаем форму с справкой
            if (helpForm != null) // проверка на то создалась ли форма успешно
            { // в случаем, если все нормально, 
                helpForm.ShowDialog(); // то выводим форму на экран
            }
        }

        /// <summary>
        /// Обработчик кнопки Undo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (richTextBoxText.CanUndo) // проверка на то возможно ли сделать undo
                richTextBoxText.Undo(); //если возможно, то делаем
        }

        /// <summary>
        /// Обработчик кнопки Redo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRedo_Click(object sender, EventArgs e)
        {
            if (richTextBoxText.CanRedo) // проверка на то возможно ли сделать redo
                richTextBoxText.Redo(); //если возможно, то делаем
        }

        /// <summary>
        /// Обработчик события изменения содержимого полей для ввода текста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextContainers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!solKernel.IsEmptyBox(textBoxSubsrting.Lines)) // проверка есть данные в поле
                {                                                  // для ввода текста
                    errorProvider.SetError(textBoxSubsrting, string.Empty); // если есть, то сбрасуем ошибку
                }
                if (!solKernel.IsEmptyBox(richTextBoxText.Lines)) // проверка есть данные в поле
                {                                                 // для ввода образца
                    errorProvider.SetError(richTextBoxText, string.Empty); // если есть, то сбрасуем ошибку
                }
                return;
            }
            catch(Exception ex) // если исключение, то выводим ошибку 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Обработчик, который выполняем новый поток
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = solKernel.SearchSubstr(e); // вызываем метод для подсчета (поиска)
            }
            catch(Exception ex) // если исключение, то выводим ошибку 
            {
                solKernel.UnblockAllButtons();
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Обработчик для события завершения нового (созданного для поиска) потока
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                solKernel.UnblockAllButtons(); // разблокируем кнопки
                if (e.Error != null) // если есть ошибки
                { // то гененрируем исключение
                    throw new Exception($"{e.Error.Message}");
                }

                int[] resSearch = (int[])e.Result; // роспаковуем результат поиска 

                if (resSearch[0] == -2) // если рез. равен -2, то ошибка при поиске
                {
                    MessageBox.Show($"Ошибка при поиске подстроки в строке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else if (resSearch[0] == -1) // если рез. равен -1, то обрзца нет
                { // и вывдоим соотв. инф. об этом
                    labelResultPosition.Text = labelResultStr.Text = "-1";
                }
                else // если нашли образец в тексте
                { // выводим инф. о его нахождении
                    labelResultStr.Text = resSearch[0].ToString();
                    labelResultPosition.Text = resSearch[1].ToString();
                    richTextBoxText.SelectionStart = resSearch[2] + resSearch[1] + 1;
                    richTextBoxText.SelectionLength = textBoxSubsrting.Lines[0].Length;
                    richTextBoxText.SelectionColor = Color.Blue;
                    richTextBoxText.Select();
                    richTextBoxText.Select(richTextBoxText.SelectionStart, richTextBoxText.SelectionLength);
                }
            }
            catch (Exception ex) // если исключение, то выводим ошибку 
            {
                solKernel.UnblockAllButtons();
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Метод для вызова необходимых методов для считывания данных
        /// </summary>
        void ReadAllFileLines()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog(); // создаем диалог для выбора пути
                string fname = Application.StartupPath + @"\default.txt"; // задаем его параметры
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.Title = "Открыть файл";
                // открываем диалог
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // если нажали на ОК
                    fname = openFileDialog.FileName; // берем буть для файла из диалога
                    solKernel.ReadAllFileLines(fname); // то вызываем метод для считывания текста 
                }
            }
            catch (Exception ex) // если исключение, то выводим ошибку 
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Метод для вызова необходимых методов для  сохранения данных
        /// </summary>
        void SaveTextInFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();  // создаем диалог для выбора пути
                string fName = "default.txt"; // задаем его параметры
                saveFileDialog.InitialDirectory = Application.StartupPath;
                saveFileDialog.Filter = "txt files (*.txt) | *.txt";
                saveFileDialog.Title = "Сохранить текст в";
                // открываем диалог
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fName = saveFileDialog.FileName; // берем буть для файла из диалога
                    solKernel.SaveTextInFile(fName); // то вызываем метод для считывания текста 
                    // выводим уведомления об успешном сохранении
                    MessageBox.Show("Файл успешно сохранен по пути:\n" + fName, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // если исключение, то выводим ошибку 
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void richTextBoxText_DoubleClick(object sender, EventArgs e)
        {
            EditTextForm editForm = new EditTextForm(this.richTextBoxText.Text);
            editForm.Show();
        }
    }
}
