using _06_Repository_Pattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        // Method that runs/Starts the application
        public void Run()
        {
            Menu();
        }

        // Menu

        private void Menu()
        {
            // Display the options to the user
            Console.WriteLine("Select a menu option:\n" +
                "1. Create New Content\n" +
                "2. View All Content\n" +
                "3. View Content By Title\n" +
                "4. Update Existing Conent\n" +
                "5. Delete Existing Content\n" +
                "6. Exit");

            //Get the user's input
            string userInput = Console.ReadLine();
            // Evalute the user's input and act accordingly
            switch (userInput)
            {
                case "1":
                    // Create new content
                    CreateNewContent();
                    break;
                case "2":
                    // View All Content
                    DisplayAllContent();
                    break;
                case "3":
                    // View Content by Title
                    DisplayContentByTitle();
                    break;
                case "4":
                    // Update Existing Content
                    UpdateExistingContent();
                    break;
                case "5":
                    // Delete Existing Content
                    DeleteExistingContent();
                    break;
                case "6":
                    // Exit
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please Enter A Vaild Number!");
                    break;
               
            }

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        } 

        // Create new StreamingContent
        private void CreateNewContent()
        {
            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("Enter the Title:");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Enter the Description:");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Enter the Rating for the content (G, PG, PG-13, NC-17, R:");
            newContent.MatureityRating = Console.ReadLine();

            Console.WriteLine("Enther the star count for the content (5.8, 10, 1.5 ect:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine();
            familyFriendlyString.ToUpper();

            if (familyFriendlyString == "Y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. Scifi \n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);




        }

        //View Current StreamingContent that is saved
        private void DisplayAllContent()
        {

        }
        // View existing Content by Title
        private void DisplayContentByTitle()
        {

        }
        //Update Existing Content

        private void UpdateExistingContent()
        {

        }

        // Delete Existing Content 
        private void DeleteExistingContent()
        {

        }
    }
}
