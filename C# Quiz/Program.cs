using System;

namespace DiceRoll
{
    class Question{
        public static int totalAnsCorrect = 0;
        public static int questionAmount = 0;
        string question = "";
        string[] answers;
        public Question(string q, string[] answers){ // answers must all be in lower case!
            this.question = q;
            this.answers = answers;
            questionAmount++;
        }

        public void askQuestion(){
            Console.WriteLine(question);
            bool ans = CheckAnswer(Console.ReadLine());
            if(ans){
                Console.WriteLine("Answer correct!");
                totalAnsCorrect++;
            }else{
                Console.WriteLine("WRONG ANSWER");
            }
        }
        bool CheckAnswer(string a){
            a = a.ToLower();
            for(int i = 0; i < answers.Length; i++){
                if(answers[i] == a){
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE TRIFLE OF TRIBES QUIZ");
            Question q1 = new Question("Who is the weakest enemy?", new string[] {"goblin", "the goblin"});
            Question q2 = new Question("You lose when what building is destroyed?", new string[] {"goldstorage", "the goldstorage", "the storage of the gold", "gold storage"});
            Question q3 = new Question("What building does the most damage?", new string[] {"mageman", "mage", "the mage", "the mageman"});
            Question q4 = new Question("What building has the most range?", new string[] {"bowman", "bow", "the bow", "the bowman"});
            q1.askQuestion();
            q2.askQuestion();
            q3.askQuestion();
            q4.askQuestion();
            Console.WriteLine("You score is " + Question.totalAnsCorrect + "/" + Question.questionAmount + " (" + ((float)Question.totalAnsCorrect / (float)Question.questionAmount) * 100 + "%).");
            if(Question.totalAnsCorrect > 2){
                Console.WriteLine("GREAT JOB!");
            }else{
                Console.WriteLine("YOU NEED TO STUDY.");
            }
        }
    }
}
