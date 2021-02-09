using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            Console.WriteLine("Здравствуйте! Представьтесь пожалуйста, напишите ваше Имя.");
            var name = GetName();
            do
            {
                var user = new User(name);
                var game = new Game(user);                               

                while (!game.End())
                {
                    var currentQuestion = game.PopGetRandomQuestion();
                    Console.WriteLine(game.GetQuestionNamberInfo());                    
                    Console.WriteLine(currentQuestion.Text);
                    var userAnswer = GetUserAnswer();
                    game.AcceptAnswer(userAnswer);                    
                }
                Console.WriteLine("Правильных ответов: " + user.CountRightAnswers);                
                var diagnose = game.CalculateDiagnose();
                Console.WriteLine(diagnose);

                UserResultsStorage.Append(user);

                Console.WriteLine("Вы хотите узнать статистику тестирования? (ДА/НЕТ)");
                bool answerYesNo = GetAnswerYesOrNo();
                if (answerYesNo)
                {
                    var users = UserResultsStorage.GetAll();
                    PrintTablе(users);
                }
                Console.WriteLine();

                Console.WriteLine("Вы хотите добавить в тестирование свою задачу? (ДА/НЕТ)");
                answerYesNo = GetAnswerYesOrNo();
                if (answerYesNo)
                {
                    AddNewQuestion();
                }
                Console.WriteLine();

                Console.WriteLine("Вы хотите пройти тест ещё раз? (ДА/НЕТ)");
                flag = GetAnswerYesOrNo();

            } while (flag);

            Console.WriteLine("До встречи! Нажмите любую клавишу... ");
            Console.ReadLine();
        }

        private static void AddNewQuestion()
        {
            Console.WriteLine("Напишите вашу задачу на одной строке (Ответом на неё должно быть целое число).");
            var userQuestion = Console.ReadLine();
            Console.WriteLine("Напишите правильный ответ на задачу (Ответ долежн быть целым числом).");
            var userAnswer = GetUserAnswer();
            var question = new Question(userQuestion, userAnswer);
            QuestionStorage.Append(question);                        
        }


        private static void PrintTablе(List<User> users)
        {
            Console.WriteLine("{0,-40}{1,-20}{2}", "Имя", "Правильных ответов", "Диагноз");

            foreach (var user in users)
            {
                Console.WriteLine("{0,-40}{1,-20}{2}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }

        private static bool GetAnswerYesOrNo()
        {
            bool answerYesNo = true;
            string yesOrNo = Console.ReadLine().ToUpper();
            while (yesOrNo != "ДА" && yesOrNo != "НЕТ")
            {
                Console.WriteLine("Напишите ваш ответ: ДА или НЕТ.");
                yesOrNo = Console.ReadLine().ToUpper();
            }
            if (yesOrNo == "НЕТ") answerYesNo = false;
            return answerYesNo;
        }

        private static string GetName()
        {
            string name = Console.ReadLine().ToUpper();
            for (int i = 0; i < name.Length; i++)
            {
                if (name.Length > 40)
                {
                    Console.WriteLine("Имя не должно превышать 40 знаков.");
                    name = Console.ReadLine().ToUpper();
                    i = -1;
                    continue;
                }
                if ((name[i] < 'А' && name[i] != 'Ё') || name[i] > 'Я')
                {
                    Console.WriteLine("Имя должно состоять только из букв русского алфавита!");
                    name = Console.ReadLine().ToUpper();
                    i = -1;
                    continue;
                }
            }
            return name;
        }       


        private static int GetRandomQuestionIndex(int haveQuestions)
        {
            var random = new Random();
            int randomQuestionIndex = random.Next(0, haveQuestions);
            return randomQuestionIndex;
        }

        private static int GetUserAnswer()
        {
            int userAnswer;
            bool correctEntry;
            do
            {
                correctEntry = Int32.TryParse(Console.ReadLine(), out userAnswer);
                if (!correctEntry)
                {
                    Console.WriteLine("Пожалуйста, введите число (не превосходящее 10^9)!");
                }
            }
            while (!correctEntry);
            return userAnswer;
        }

    }
}


