using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary
{
    public class QuestionStorage
    {
        public static string Path = "questions.json";

        public static void Append(Question question)
        {
            var allQuestions = GetAll();
            allQuestions.Add(question);
            Save(allQuestions);
        }

        public static List<Question> GetAll()
        {            
            if (!File.Exists(Path))
            {
                var questions = new List<Question>
                {
                    new Question("Сколько будет два плюс два  умноженное на два?", 6),
                    new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9),
                    new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                    new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60),
                    new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2)
                };
                Save(questions);
                return questions;
            }
            var fileData = FileProvider.Get(Path);
            var allQuestions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            return allQuestions;            
        }
        static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }
    }
}
