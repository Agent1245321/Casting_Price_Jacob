using System;

namespace Casting_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello User! How About tell me your favorite number?");
            
            
            int favNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now, do you like Unity?");

            

            String[] yeses = { "Yes", "Yep", "Absolutely", "Yee", "True", "yes", "yep", "absolutely", "yee", "true", "OH YEAH!!!" };

            String[] nos = { "Nope", "Notta", "No Way", "No", "Nah", "nope", "notta", "no way", "no", "nah" };

            bool tf;
            answerMethod(); 

            

        void answerMethod()
        {

                String answer = Console.ReadLine();
                var yesAns = Array.Find(yeses, element => element == answer);
                var noAns = Array.Find(nos, element => element == answer);

                if (yesAns != null)
                {
                    tf = true;
                    Console.WriteLine("Cool!");
                }

                if (noAns != null)
                {
                    tf = false;
                    Console.WriteLine("Lame");
                }

                if (noAns == null && yesAns == null)
                {
                    Console.WriteLine("Im Sorry, But I Dont Recognize that lingo");

                    answerMethod();

                }

            }
        }
    }
}
