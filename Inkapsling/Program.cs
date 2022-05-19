using Inkapsling_Övn_3;
using System;

namespace Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //Person kalleKula = new Person();

            //try {
            //    kalleKula.FirstName = "Karl";
            //    kalleKula.LastName = "Kula";
            //    kalleKula.Age = 0;
            //    kalleKula.Height = 110;
            //    kalleKula.Weight = 200;
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: \n\r{ex}\n");
            //}

            PersonHandler personHandler = new PersonHandler();

            try
            {
                

                Person kallekula = new Person();
                kallekula = personHandler.CreatePerson(age: 45, fname: "Karl", lname: "Kula", height: 1.63, weight: 92.42);

                //personHandler.SetAge(kallekula, 0);             // Cause error
                //personHandler.SetFirstName(kallekula, "");      // Cause error
                //personHandler.SetLastName(kallekula, null);     // Cause error
                //personHandler.SetHeight(kallekula, 0.0);        // Cause error
                //personHandler.SetWeight(kallekula, null);       // Cause error


                //kallekula.Age = 46;
                personHandler.SetAge(kallekula, 46);
                personHandler.SetHeight(kallekula, 1.65);
                personHandler.SetWeight(kallekula, 93.31);

                Console.WriteLine($"First name: {kallekula.FirstName}");
                Console.WriteLine($"Last name:  {kallekula.LastName}");
                Console.WriteLine($"Age:        {kallekula.Age}");
                Console.WriteLine($"Height:     {kallekula.Height}");
                Console.WriteLine($"Weight:     {kallekula.Weight}\n");

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: \n\r{ex}\n");
            }


            List<UserError> userErrors = new List<UserError>();

            UserError userTextError = new TextInputError();
            UserError userNumericError = new NumericInputError();
            UserError userInvalidError = new NullOrWhiteSpaceInputError();

            // OBS: make ranged error


            userErrors.Add(userTextError);
            userErrors.Add(userNumericError);
            userErrors.Add(userInvalidError);
            userErrors.Add(userNumericError);

            foreach (UserError error in userErrors)
            {
                Console.WriteLine($"{error.UEMessage()}");
            }

            // OBS: Arv övn 3
            Wolfman wolfman = new Wolfman();
            string sound = wolfman.DoSound();
            string talk = wolfman.Talk();

            Console.WriteLine(sound);
            Console.WriteLine(talk);

        }

    }
}
