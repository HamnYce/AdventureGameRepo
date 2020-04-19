using System;
//program to create random character stats
namespace RandomCharStats
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("You round a corner and you see ... ");
            //making an instance of the character class called 'person'
            Character person = new Character();
            //running the characterInformation method from the person class instance
            person.characterInformation();
            Console.ReadKey();
        }
    }
    //creating class 'Character's
    class Character
    {
        //initing variables to store the random quality. i.e. name, eye color etc.
        private string Name;
        private string EyeColor;
        private string HairColor;
        private string ObjectAdjective;
        private string Object;

        //initing random variable called myRandom
        private static Random myRandom = new Random();

        //creating character method/function to store the vars that were created using the random class
        public Character()
        {
            //assigning the random character qualities to their apropriate variables
            this.Name = getName();
            this.EyeColor = getEyeColor();
            this.HairColor = getHairColor();
            this.Object = getObject();
            this.ObjectAdjective = getObjectAdjective();
        }
        //creating a seperate method to acquire relevant character quality

        private string getName()
        {
            //creating string array with the pool of possible names, eye color etc.
            string[] nameList = new String[] { "Andy", "Abel", "Alan", "George", "Samuel", "Dan" };
            //`
            return nameList[getRandomNumber(nameList.Length)];
        }

        private string getEyeColor()
        {
            string[] colorList = new String[] { "blue", "green", "grey", "brown", "hazel" };
            return colorList[getRandomNumber(colorList.Length)];
        }

        private string getHairColor()
        {
            string[] hairColorList = new String[] { "blue", "green", "grey", "brown", "hazel" };
            return hairColorList[getRandomNumber(hairColorList.Length)];
        }

        private string getObject()
        {
            string[] objectList = new String[] { "orb", "hat", "spoon", "book", "widget" };
            return objectList[getRandomNumber(objectList.Length)];
        }

        private string getObjectAdjective()
        {
            string[] adjectiveList = new String[] { "shiny", "worn", "rugged", "purple", "glittery" };
            return adjectiveList[getRandomNumber(adjectiveList.Length)];
        }

        private int getRandomNumber(int range)
        {
            return myRandom.Next(range);
        }
        public void characterInformation()
        {
            Console.WriteLine(Name + ", a " + EyeColor + "-eyed, " + HairColor + " haired person holding a " + ObjectAdjective + " " + Object
                + ".");
        }
    }
     

}
