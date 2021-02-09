using System;
using System.Collections.Generic;

namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        private List<Question> questions;
        private int allQuestionsCount;
        private User user;
        private Question currentQuestion;
        private int questionNumber = 0;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionStorage.GetAll();
            allQuestionsCount = questions.Count;

        }
        public Question PopGetRandomQuestion()
        {
            questionNumber++;
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);
            return currentQuestion;
        }
        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
        }
        public string CalculateDiagnose()
        {
            DiagnoseCalculator.Calculate(user, allQuestionsCount);
            return user.Name + ", ваш диагноз: " + user.Diagnose;
        }
        public bool End()
        {
            return questions.Count == 0;
        }

        public string GetQuestionNamberInfo()
        {
            return "Вопрос № " + questionNumber;
        }
    }
}
