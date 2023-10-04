using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
     class ApplicationFruits
    {
        public List<string> Fruits {  get; set; }

        public ApplicationFruits()
        {
            this.Fruits = new List<string>();
        }

        public void DisplayFruits()
        {
            Console.WriteLine($"Voici la composition du menu :");
            foreach(string fruit in Fruits) {
                Console.WriteLine(fruit);
            }
        }

        public string DisplayActions()
        {
            Console.WriteLine(" 1 : Ajouter un élément");
            Console.WriteLine("2 : Supprimer un élément du menu ");
            Console.WriteLine("3 : Quitter");
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        public void AddAction()
        {
            string fruit = Console.ReadLine();
            while(string.IsNullOrEmpty(fruit)) {
                 fruit = Console.ReadLine();
            }
            Fruits.Add(fruit);
        }

        public void DeleteAction() 
        {
            Console.WriteLine("Quel est l'index de l'élément que vous voulez supprimer ? ");
            string stringIndex = Console.ReadLine();
            int index = Int32.Parse(stringIndex);
            Fruits.RemoveAt(index);
            DisplayFruits();
        }

        public void ApplicationStarter(string UserInput) {
         switch(UserInput)
            {
                case "1":
                    AddAction(); 
                    break;
                case "2":
                    DeleteAction();
                    break;
                case "3":
                    Console.WriteLine("Vous venez de quitter le programme");
                    break;
            }
        }

    }
}
