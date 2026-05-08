using Task3Model;

namespace Task3ModelTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()//общие данные
        {
            Worker worker = new Worker();
        }

        [Test]
        public void AvgArrayCorrect()//правильный тест на функцию AvgArray
        {
            string array = "-5\n-3\n2\n10\n0\n";
            Console.SetIn(new StringReader(array));
            Worker worker = new Worker();
            double avg = worker.AvgArray();
            Assert.That(avg, Is.EqualTo(-4));
        }
        [Test]
        public void AvgArrayNull()// 0 как итог
        {
            string input = "2\n5\n10\n0\n";
            Console.SetIn(new StringReader(input));
            Worker worker = new Worker();
            double avg = worker.AvgArray();
            Assert.That(double.IsNaN(avg), Is.True);
        }
        [Test]
        public void AvgArrayError()//исключение на функции AvgArray
        {

            string input = "abc\n0\n"; 
            Console.SetIn(new StringReader(input));
            Worker worker = new Worker();
            Assert.Throws<FormatException>(() => worker.AvgArray());
        }

        [Test]
        public void PolydromCorrect_True()//правильный тест на функцию Polydrom для слова полиндрома
        {
            string testString = "казак";
            Worker worker = new Worker();
            bool result = worker.Polydrom(testString);
            Assert.That(result, Is.True);
        }

        [Test]
        public void PolydromCorrect_False()//правильный тест на функцию Polydrom для слова не полиндрома
        {
            string testString = "hello";
            Worker worker = new Worker();
            bool result = worker.Polydrom(testString);
            Assert.That(result, Is.False);
        }

        [Test]
        public void PolydromError()//Ошибка строка null
        {
            string testString = null;
            Worker worker = new Worker();
            Assert.Throws<NullReferenceException>(() => worker.Polydrom(testString));
        }

        [Test]
        public void LettersCorrect_Сoincidence()//правильный тест на функцию Letters с совпадающими символами
        {
            string str1 = "hello";
            string str2 = "world";
            Worker worker = new Worker();
            string result = worker.Letters(str1, str2);
            Assert.That(result, Does.Contain("l"));
            Assert.That(result, Does.Contain("o"));
        }

        [Test]
        public void LettersCorrect_NoСoincidence()//правильный тест на функцию Letters без совпадающих символов
        {
            string str1 = "abc";
            string str2 = "def";
            Worker worker = new Worker();
            string result = worker.Letters(str1, str2);
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void LettersError()///Ошибка строка null
        {
            string str1 = null;
            string str2 = "abc";
            Worker worker = new Worker();
            Assert.Throws<NullReferenceException>(() => worker.Letters(str1, str2));
        }
    }
}
