using Microsoft.VisualStudio.TestTools.UnitTesting;
using Course_proj_KMP_serch;

namespace Course_proj_KMP_search_UnitTests
{
    [TestClass]
    public class CourseProj_UnitTest
    {
        /// <summary>
        /// Тест для проверки работы метода для вычисления Пи-функции для строки
        /// </summary>
        [TestMethod]
        public void TestMethod_GetPiFuncArray()
        {
            // Arrange
            string substrTested = "ababbacaabac"; // текст, для которого будем считать Пи-функцию
            int[] expectedRes = new int[] { 0, 0, 1, 2, 0, 1, 0, 1, 1, 2, 3, 0 }; // ожидаемый результат
            KMP_Search algorLogic = new KMP_Search(ref substrTested); // экземпляр класса для реализ. КМП-поиска 
            // Act 
            int[] gettedRes = algorLogic.GetPiFuncArray(); // вызываем метод для подсчета пи-функции для текста
            // Assert
            CollectionAssert.AreEqual(expectedRes, gettedRes); // сравневаем ожидаемый и полученный результат
        }

        /// <summary>
        /// Тест для проверки работы КМП-поиска с украинским языком
        /// </summary>
        [TestMethod]
        public void TestMethod_KMPSearch_Ukrainian()
        {
            // Arrange
            string substrTested = "мудрість"; // образце, который необхоимо найти
            string text = "якби ви вчились так як треба то й мудрість би була своя"; // текст, в которм будет ити поиск
            int expectedRes = 34; // ожиадемый индекс нахождения
            KMP_Search algorLogic = new KMP_Search(ref substrTested); // экземпляр класса для реализ. КМП-поиска 
            // Act
            algorLogic.String = text; // устанав. знач. текста для экземпялра
            int gettedRes = algorLogic.KMPSearch(); // вызываем метод для поиска
            // Assert
            Assert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата
        }

        /// <summary>
        /// Тест для проверки работы КМП-поиска с английским языком
        /// </summary>
        [TestMethod]
        public void TestMethod_KMPSearch_English()
        {
            // Arrange
            string substrTested = "tal of the"; // образце, который необхоимо найти
            string text = "London is the capital of the Great Britain"; // текст, в которм будет ити поиск
            int expectedRes = 18;  // ожиадемый индекс нахождения
            KMP_Search algorLogic = new KMP_Search(ref substrTested); // экземпляр класса для реализ. КМП-поиска 
            // Act
            algorLogic.String = text; // устанав. знач. текста для экземпялра
            int gettedRes = algorLogic.KMPSearch(); // вызываем метод для поиска
            // Assert
            Assert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата
        }

        /// <summary>
        /// Тест для проверки работы КМП-поиска с русским языком
        /// </summary>
        [TestMethod]
        public void TestMethod_KMPSearch_Russian()
        {
            // Arrange
            string substrTested = "це - де";
            string text = "Тепло и солнце - день чудесный, курсовой сдавать пора"; // текст, в которм будет ити поиск
            int expectedRes = 12;  // ожиадемый индекс нахождения
            KMP_Search algorLogic = new KMP_Search(ref substrTested); // экземпляр класса для реализ. КМП-поиска 
            // Act
            algorLogic.String = text; // устанав. знач. текста для экземпялра
            int gettedRes = algorLogic.KMPSearch(); // вызываем метод для поиска
            // Assert
            Assert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата
        }

        /// <summary>
        /// Тест для проверки работы метода для считывания данных из файла
        /// </summary>
        [TestMethod]
        public void TestMethod_OpenFile()
        {
            // Arrange
            string[] expectedRes = new string[] { "Course Project", "Tymoshenko Oleh 525-b"}; // ожидаемые считанные данные 
            string fName = "C:\\Users\\Oleh\\Desktop\\large\\testFile.txt"; // путь к файлу, из которого необходимо читать
            FileLogic fileLogic = new FileLogic(); // экземпляр класса для реализ. робты с файлом
            // Act
            string[] gettedRes = fileLogic.OpenFile(fName); // вызыв. метод для открытия файла
            //Assert
            CollectionAssert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата  
        }

        /// <summary>
        /// Тест для проверки работы метода для сохранения в паре с считыванием данных из файла
        /// </summary>
        [TestMethod]
        public void TestMethod_SaveInFileAndOpenFile()
        {
            // Arrange
            // ожидаемые считанные данны
            string[] expectedAndSavingInf = new string[] {"Test Method FileLogic.SaveInFile", "Course Project", "Tymoshenko Oleh 525-b" };
            string fName = "C:\\Users\\Oleh\\Desktop\\large\\testFileSaving.txt"; // путь к файлу, из которого необходимо читать
            FileLogic fileLogic = new FileLogic(); // экземпляр класса для реализ. робты с файлом
            // Act
            string gettedResSaving = fileLogic.SaveInFile( expectedAndSavingInf, ref fName); // вызыв. метод для сохранения файла
            //Assert
            if (gettedResSaving != null) // если ошибка при сохранении
                throw new System.Exception();
            string[] readedInf = fileLogic.OpenFile(fName); // вызыв. метод для считывания данных для проверки на сходство из теми,
            // которые сохранили
            CollectionAssert.AreEqual(expectedAndSavingInf, readedInf); // сравнение ожидидаемого и полученного результата
        }

        /// <summary>
        /// Тест для проверки работы метода для проверки на то имеються ли абсолютно символы в двумерном массиве 
        /// при случае, когда они есть
        /// </summary>
        [TestMethod]
        public void TestMethod_IsEmptyBox_When_False()
        {
            // Arrange
            bool expectedRes = false; // ожидаемы результат
            string[] linesForCheck = new string[] { "Course Project", "Tymoshenko Oleh 525-b" }; // текст для проверки 
            Interface_prog tmpForm = new Interface_prog(); // экземпляр класа интерфейса для создания класса с логикой программы, 
             // для полочуния доступа к необходимому методу
            SolutionKernel solKernel = new SolutionKernel(tmpForm); // создаем экземпяляр, который предоставляет необходимый метод
            // Act
            bool gettedRes = solKernel.IsEmptyBox(linesForCheck); // вызываем метод для проверки 
            //Assert
            Assert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата
        }

        /// <summary>
        /// Тест для проверки работы метода для проверки на то имеються ли абсолютно символы в двумерном массиве 
        /// при случае, когда их нет
        /// </summary>
        [TestMethod]
        public void TestMethod_IsEmptyBox_When_True()
        {
            // Arrange
            bool expectedRes = true; // ожидаемы результат
            string[] linesForCheck = new string[] {""}; // текст для проверки 
            Interface_prog tmpForm = new Interface_prog();// экземпляр класа интерфейса для создания класса с логикой программы, 
            // для полочуния доступа к необходимому методу
            SolutionKernel solKernel = new SolutionKernel(tmpForm); // создаем экземпяляр, который предоставляет необходимый метод
            // Act
            bool gettedRes = solKernel.IsEmptyBox(linesForCheck); // вызываем метод для проверки
            //Assert
            Assert.AreEqual(expectedRes, gettedRes); // сравнение ожидидаемого и полученного результата
        }
    }
}
