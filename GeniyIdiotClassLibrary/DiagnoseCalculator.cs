namespace GeniyIdiotClassLibrary
{
    public class DiagnoseCalculator
    {
        public static void Calculate(User user, int countQuestions)
        {
            var percentRightAnswers = (double)user.CountRightAnswers * 100 / countQuestions;
            var diagnoses = GetDiagnoses();
            if (percentRightAnswers == 0)
            {
                user.Diagnose = diagnoses[0];
                return;
            }
            if (percentRightAnswers <= 20)
            {
                user.Diagnose = diagnoses[1];
                return;
            }
            if (percentRightAnswers <= 40)
            {
                user.Diagnose = diagnoses[2];
                return;
            }
            if (percentRightAnswers <= 60)
            {
                user.Diagnose = diagnoses[3];
                return;
            }
            if (percentRightAnswers <= 80)
            {
                user.Diagnose = diagnoses[4];
                return;
            }
            user.Diagnose = diagnoses[5];
        }
        public static string[] GetDiagnoses()
        {
            var diagnoses = new string[]
            {
                "Идиот",
                "Кретин",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений"
            };
            return diagnoses;
        }
    }
}
