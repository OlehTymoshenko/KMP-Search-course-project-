using System;

namespace Course_proj_KMP_serch
{
    /// <summary>
    /// Класс_2 для реализации компонента Controller
    /// </summary>
    public class KMP_Search
    {
        /// <summary>
        /// Поле хранящее массив со значениями P-функции для обрзца
        /// </summary>
        public int[] piFuncArr;
        
        /// <summary>
        /// Поле для образца
        /// </summary>
        string _substring;

        /// <summary>
        /// Поле для текста
        /// </summary>
        string _string;

        /// <summary>
        /// Свойство для обзраца
        /// </summary>
        public string Substring
        {
            get
            {
                return _substring;
            }

            set
            {
                // если присв. не null и длина образца больше 0
                if (value != null && value.Length > 0) 
                {
                    _substring = value; // то присваиваем значение
                    ChangeSubstring(); // пересчитуем массив со значениями
                                       // P -функции для образца
                }
            }
        }

        /// <summary>
        /// Свойство для текста
        /// </summary>
        public string String
        {
            get
            {
                return _string;
            }

            set
            {
                // если присв. не null и длина текста больше длины обзраца
                if (value != null && value.Length >= Substring.Length)
                    _string = value;
            }
        }

        /// <summary>
        /// Конструктор только с параметром-образец
        /// </summary>
        /// <param name="substr"></param>
        public KMP_Search(ref string substr)
        {
            Substring = substr; // присв. свойству значение обзраца
            ChangeSubstring(); // считаем массив со значениями P-функции для образца
        }

        /// <summary>
        /// Конструктор с параметрами - текст и  образец
        /// </summary>
        /// <param name="str"></param>
        /// <param name="substr"></param>
        public KMP_Search(ref string str, ref string substr)
        {
            Substring = substr; // присв. свойству значение обзраца
            String = str; // присв. свойству значение текста
            ChangeSubstring(); // считаем массив со значениями P-функции для образца
        }

        /// <summary>
        /// Метод ля пересчета массива со значениями P-функции для образца
        /// </summary>
        void ChangeSubstring()
        {
            // вызываем метод для подсчета массива со значениями P-функции для образца
            piFuncArr = GetPiFuncArray();
        }

        /// <summary>
        /// Метод реализующий логику КМП-поиска
        /// </summary>
        /// <returns></returns>
        public int KMPSearch()
        {
            try
            {
                // создаем 2 индекста -текста и образца
                int stringIndex = 0, substringIndex = 0;
                // если массив со значениями P-функции для образца равен null,  
                if (piFuncArr == null) // то генерируем исключение
                    throw new Exception();
                // пока индекс строки меньше длины строки, т.е. по всем элементам проходим
                while (stringIndex < _string.Length)
                {
                    // Если текущий элемент строки и обрзаца совпал
                    if (_string[stringIndex] == _substring[substringIndex])
                    { // то сдвигаем оба индекса впаво на 1 символ 
                        stringIndex++;
                        substringIndex++;
                        // если индекс образца равен длине образца, то нашли образец
                        if (substringIndex == _substring.Length) 
                        {
                            // возв. индекс первого вхождения образца
                            return stringIndex - substringIndex;
                        }
                    }
                    else if (substringIndex == 0) // если индекс подстроки равен 0
                    {
                        stringIndex++; // увеличуем индес строки
                        if (stringIndex == _string.Length) // если индекс строки равен длине строки, то вхождения нет
                        { // и возвращаем -1
                            return -1;
                        }
                    }
                    else // индексу подстроки присв. знач. значение P-функции для предыдущего элемента 
                    {
                        substringIndex = piFuncArr[substringIndex -   1];
                    }
                }
                return -1; // если вышли из цикла, значит вхождения нет
            }
            catch (Exception) // если исключение то возв. -2
            {
                return -2;
            }
        }

        /// <summary>
        /// Метод для получения массив со значениями P-функции для обрзца
        /// </summary>
        /// <returns></returns>
        public int[] GetPiFuncArray()
        {
            try
            {
                // создаем массив длины подстроки
                int[] PiFuncArr = new int[_substring.Length];
                int i = 1, j = 0; // создаем два индекса с нач. значениям
                PiFuncArr[0] = 0; // 0-вой элемент обзразца всегда имеет знач. 0
                // пока не прошли
                while (i < PiFuncArr.Length)
                {
                    // если i-й и j-й элемент обзаца совпали  
                    if (_substring[i] == _substring[j])
                    { // то знач. равно i-го элемента равно j + 1
                        PiFuncArr[i] = j + 1;
                        i++; // увеличем оба индекса на 1
                        j++;
                    }
                    else if (j == 0) // если индекс j равен 0
                    { // то i-й элемент будет равен 0, увеличуем i
                        PiFuncArr[i] = 0;
                        i++;
                    }
                    else // иначе j-й элемент будет равен предыдущему для j элементу массива 
                    {
                        j = PiFuncArr[j - 1];
                    }
                }
                return PiFuncArr; // возв. массив 
            }
            catch (Exception) // если исключение, то возв. null
            {
                return null;
            }
        }
     }
}
