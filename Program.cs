using System;
using System.Collections.Generic;   //FOR USING LIST, ITS REQUIRED
using System.Linq;                  //FOR USING LINQ, ITS REQUIRED

namespace sanam_maharjan
{
    class Program
    {


//-------------------------------------------------------------------------CHAPTER 1---------------------------------------------------------
    /*     static void Main()
        {
            //--------------------PRINT---------------
            /* // 1. printing lines
            Console.WriteLine("Hello, World!"); */
            
            /* // 2.getting input
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old"); */
                        
        /*     Console.ReadKey();  
        } */ 




//-----------------------------------------------------------------------CHAPTER 2-------------------------------------------------------------------
        //---------- DATA TYPES AND VARIABLES--------------
        /* static void Main(string[] args)
        { */
            
            /* string name = "Shadow";
            string breed = "Golden Retriever";
            Console.WriteLine(name + " " + breed);

            int age = 5;
            Console.WriteLine(age);

            double weight = 65.22;
            Console.WriteLine(weight);

            bool spayed = true;
            Console.WriteLine(spayed); */


            //CONVERTING DATATYPES
            /* Console.Write("Enter your favorite number!: ");
            int faveNumber = Console.ReadLine(); //not possible (readline takes input as string[always])
            int faveNumber = (int)Console.ReadLine(); // cannot be converted like this
            int faveNumber = Convert.ToInt32(Console.ReadLine()); //correct way */

            /* double myDouble = 3.2;
            // Round myDouble to the nearest whole number
            int myInt = myDouble; // this doesnt work as implicit datatype conversion will result in loss of data
            int myInt = (int)myDouble; // to convert explicitly, int is added

            int myInt = 3;
            // Turn it into a double
            double myDouble = myInt; // this works as inplicit datatype conversion will not loss any data */

            /* bool x = true;
            Console.WriteLine(x);
            string myString = Convert.ToString(x);
            Console.WriteLine(myString);

            string mySingleString = "S";
            char myChar = Convert.ToChar(mySingleString);
            Console.WriteLine(myChar); */


            //-------working with numbers------
            /* int pizzaShops = 4332;
            int totalEmployees = 86928;
            double revenue = 390819.28;
            decimal point = 486.325m;  //'m' is added at last so that computer wont get confuse between decimal and double
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);
            Console.WriteLine(point); */


            // ARITHEMATIC OPERATORS
            /* // Your Age
            int userAge = 22;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge); */


            //OPERATOR SHORTCUTS
           /*  // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps); */


            //MODULO
            /* // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 4;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);*/


            //BUILT-IN METHODS
            /* // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Abs(numberTwo);

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            double numberOne1 = 6.5;
            double numberTwo2 = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne1, numberTwo2));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne1));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne1, numberTwo2)); */


            //----------Working with texts-----------------
            //ESCAPE CHARACTER
            /* string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\""; // "\"=escape character : use to indicate that " is not the end of string
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");  //creates an empty line
            Console.WriteLine(firstSpeech); */
            
            // STRING CONCATENATION
            /* string beginning = "Once upon a time";
            string middle = "there was a old man";
            string end = "He died due to cancer";
            string story= beginning + ", " + middle + ". " + end + ".";
            Console.WriteLine(story); */
            
            //STRING INTERPOLATION
            /* string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";
            string story= $"{beginning} {middle}. {end}";
            Console.WriteLine(story); */

            // .LENGTH AND .INDEXOF
            /* string password = "a92301j2add";
            int passwordLength = password.Length;  //returns the lenth of password
            int passwordCheck = password.IndexOf("9");  //returns the index of 9 on the password
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check."); */
            
            // .SUBSTRING AND BRACKET NOTATION
            /* string startStrand = "ATGCGATGAGCTTAC";           
            int tga = startStrand.IndexOf("TGA");   // find location of "tga"
            int startPoint = 2;
            int length = tga + 3;
            string dna = startStrand.Substring(startPoint, length);  //returns a part of the string
            Console.WriteLine(dna);
            Console.WriteLine(dna[3]);  //bracket notaion = [x] : returns the value in x; x may be integer, variable */

            // OVERALL USE OF METHODS
            /* string drink = "wine";
            string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

            int storyLength = madTeaParty.Length;
            string toFind = "March Hare";

            string findLowerCase = toFind.ToLower(); 
            int findMarchHare = madTeaParty.IndexOf(toFind);

            Console.WriteLine(madTeaParty.Substring(findMarchHare));
            Console.WriteLine($"This scene is {storyLength} long.\n");
            Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}."); */
            
            //MANIPULATE STRINGS .TOUPPER AND .TOLOWER
            /* string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            charPosition = script.IndexOf("a portrait");
            Console.WriteLine(charPosition);
            string sceneDescription = script.Substring(charPosition);
       
            cameraDirections = cameraDirections.ToUpper();  // Make camera directions uppercase
        
            sceneDescription = sceneDescription.ToLower();  // Make scene description lowercase

            Console.WriteLine($"{cameraDirections} {sceneDescription}");
             */

            //PRACTICE  
            /* string name = "Sanam Maharjan";
            int charPosition = name.IndexOf("Sanam");
            string name1 = name.Substring(charPosition, 2);
            int charPosition1 = name.IndexOf("Mahar");
            string name2 = name.Substring(charPosition1, 5);
            int charPosition2 = name.IndexOf("nam");
            string name3 = name.Substring(charPosition2, 3);
            int charPosition3 = name.IndexOf("jan");
            string name4 = name.Substring(charPosition3);

            name1= name1.ToUpper();
            name2= name2.ToLower();
            name3= name3.ToUpper();
            name4= name4.ToUpper();

            Console.WriteLine($"{name1}{name3} {name2}{name4}"); */
          /*   Console.ReadKey();
        } */


//----------------------------------------------------------------CHAPTER 3------------------------------------------------
        //LOGIC AND CONDITIONALS
        /* static void Main(string[] args)
        { */
            //--------------UNDERSTANDING LOGIC IN C#-------------------------
            //BOOLEAN DATA TYPE
            /* //The number 500 is greater than 24.
            bool answerOne = true;
            //“coffee” contains the letter “a”.
            bool answerTwo = false;
            Console.WriteLine(answerOne + " " + answerTwo); */

            //COMPARISION OPERATOR
            /* double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            double tripDuration = distance / rate;
            bool answer = tripDuration <= timeToDinner;     //other comparision operators like: == != < > <= >=
            Console.WriteLine(answer); */

            //LOGICAL OPERATOR
            /* bool andExample = ((4 > 1) && (2 < 7)); 
            bool orExample = ((8 > 6) || (3 > 6));
            bool notExample = !(1 < 3);
            Console.WriteLine(andExample);
            Console.WriteLine(orExample);
            Console.WriteLine(notExample); 

            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;

            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision);*/

            //----------CONDITIONAL STATEMENTS------------------
            //IF STATEMENT
            /* int socks = 3;
            if (socks <=3)
            {
                Console.WriteLine("Time to do laundry!");
            } */

            //IF ELSE STATEMENT
            /* int people = 20;
            string weather = "nice";

            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            } */

            //ELSE IF STATEMENT
            /* int guests = 0;
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            else if (guests >= 1){
                Console.WriteLine("Innovation");
            }
            else
            {
                Console.WriteLine("Solitaire");
            } */

            //SWITCH STATEMENT
            /* Console.WriteLine("Choose a movie genre: ");
            string genre = Console.ReadLine();
            switch (genre)
            {
                case "Drama":
                Console.WriteLine("Citizen Kane");
                break;

                case "Comedy":
                Console.WriteLine("Duck Soup");
                break;

                case "Adventure":
                Console.WriteLine("King Kong");
                break;

                case "Horror":
                Console.WriteLine("Psycho");
                break;

                case "Science Fiction":
                Console.WriteLine("2001: A Space Odyssey");
                break;

                default:
                Console.WriteLine("No movie found");
                break;
            }*/

            //TERNARY OPERATOR
            /* int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
            Console.WriteLine(message); */

            //PRACTICE
            /* int ourNumber = 7;
            Console.WriteLine("Guess a number between 1 to 10");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            
            if(guessedNumber > ourNumber)
            {
                Console.WriteLine("too high");
            }
            else if(guessedNumber < ourNumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("correct guess");
            } */
            
            
            /* Console.ReadKey();
        } */


// ------------------------------------------------------ CHAPTER 4----------------------------------------------------
        //METHODS
        /* static void Main(string[] args)
        { */
            //---------------------METHOD CALLS AND INPUT--------------------
            //CALL A METHOD
            /* string msg = "Yabba dabba doo!";
            Math.Min(2 ,5);
            Console.WriteLine(msg);
            Console.WriteLine(msg.Substring(0 , 1)); */

            //CAPTURE OUTPUT
            /* string designer = "Anders Hejlsberg";
            int  indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace + 1);
            Console.WriteLine(secondName); */

            //DEFINE A METHOD
            /*  VisitPlanets();*/

            //DEFINE PARAMETERS
            /* VisitPlanets(3);
            VisitPlanets(10);
            VisitPlanets(2); 
            VisitPlanets();*/ 

            //NAMED ARGUMENTS
            /* VisitPlanets();
            VisitPlanets(numberOfPlanets : 2);
            VisitPlanets(numberOfPlanets : 2, name : "Sanam Maharjan"); */

            //METHOD OVERLOADING
            /* NamePets("Laika", "Albert");
            NamePets("Mango", "Puddy", "Bucket");
            NamePets(); */


            /* Console.ReadKey();
        } */

        /* static void VisitPlanets()   //DEFINE A METHOD
        {
            Console.WriteLine("You visited many new planets...");
        } */

        /* static void VisitPlanets(int numberOfPlanets)    //DEFINE PARAMETERS
        {
            Console.WriteLine($"You visited {numberOfPlanets} planets...");
        } */
        /* static void VisitPlanets(int numberOfPlanets = 0) //OPTIONAL PARAMETERS: if no arguments are given, then value will be 0 for this method
        {
            Console.WriteLine($"You visited {numberOfPlanets} planets...");
        } */
        /* static void VisitPlanets(
            string adjective = "brave",
            string name = "Cosmonaut", 
            int numberOfPlanets = 0,
            double gForce = 4.2)        //NAMED ARGUMENTS
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        } */


        /* static void NamePets(string pet1, string pet2)               //METHOD OVERLOADING
        {
            Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
        }

        static void NamePets(string pet1, string pet2, string pet3)
        {
            Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your space!");
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        } */



        /* static void Main(string[] args)
        { */
            //--------------METHOD OUTPUT-----------------------------------
            //RETURN
            /* Console.WriteLine(DecoratePlanet("Jupiter")); */

            //  OUT => used to convert the datatype of a data and returns the result of conversion whether it is successful or not
                //IN SHORT, OUT IS USED TI RETURN MULTIPLE VALUES FROM METHOD
            /* string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;
            int nameAsInt;
            bool outcome2;
            outcome = Int32.TryParse(ageAsString, out ageAsInt);    //converts string data to int and returns true as conversion becomes success
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt); //converts string data to int and returns false as conversion becomes unsuccess
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);   //0 is stored if unsuccess */

            //USING OUT
            /* string statement = "GARRRR";
			string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur);
            Console.WriteLine(marker); */

            //-------------------------------ALTERNATE EXPRESSION-------------------------
            //EXPRESSION-BODIED  =>
            /* Welcome("Earth");
            double days = 500;
            double rotations = DaysToRotations(days);
            Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s)."); */

            //METHODS AS ARGUMENTS
            /* string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
            string firstLongAdjective = Array.Find(adjectives, IsLong);    
            Console.WriteLine($"The first long word is: {firstLongAdjective}."); */

            //LAMBDA EXPRESSION
            /* int[] numbers = {10, 20, 24, 36, 40};
            string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite"); 
                //INSTESD OF CREATING METHOD, USE LAMBDA EXPRESSION  
                    //static bool HitGround(string s)
                    //{
                    //    return s == "meteorite";
                    //}  
            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            } 
            bool hasBigDozen = Array.Exists(numbers, (int num) => {         //IF HAVE MANY EXPRESSION, USE {} FOR LAMBDA EXPRESSION
                bool isDozenMultiple = num % 12 == 0;
                bool greaterThan20 = num > 20;
                return isDozenMultiple && greaterThan20;
                }
            );
            Console.WriteLine(hasBigDozen); */

            //SHORTER LAMBA EXPRESSION
            /*  1.   We can remove the parameter type if it can be inferred
                2.   We can remove the parentheses if there is one parameter */
            /* int[] numbers = {10, 20, 24, 36, 40};
            string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};     
            bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");   //LAMBDA EXPRESSION SHORTEN     
            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
            bool hasBigDozen = Array.Exists(numbers, num => {       //LAMBDA EXPRESSION SHORTEN
                bool isDozenMultiple = num % 12 == 0;               //AS % IS USED WITH NUM AND
                bool greaterThan20 = num > 20;                      //COMPARED WITH 20 WHICH IS ONLY POSSIBLE WITH THE INTEGER DATATYPES
                return isDozenMultiple && greaterThan20;            //IT IS OKAY TO NOT WRITE DATATYPE ABOVE AS COMPUTER KNOWS IT
                }
            );
            Console.WriteLine(hasBigDozen); */

            /* Console.ReadKey();
        } */

        /* static string DecoratePlanet(string planet)  //RETURN
        {
            return $"*.*.* Welcome to {planet} *.*.*";
        } */

        /* static string Whisper(string phrase, out bool wasWhisperCalled)     //USING OUT
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        } */
        //static double DaysToRotations(double days) => days / 365; //ALTERNATE EXPRESSION FOR BELOW METHOD (CAN BE USED IF A METHOD HAS ONLY ONE EXPRESSION)
                /* static double DaysToRotations(double days)
                {
                    return days / 365;
                }  */
        //static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");   //ALTERNATE EXPRESSION FOR BELOW METHOD 
                /* static void Welcome(string planet)
                {
                    Console.WriteLine($"Welcome to {planet}!");
                } */
        /* public static bool IsLong(string word)       //METHODS AS ARGUMENTS
        {
            return word.Length > 8;
        }*/

        //---------------------------------------------------CHAPTER 5-------------------------------------------------------------------------
        //ARRAYS AND LOOPS
        /* static void Main(string[] args)
        { */
            //-------------------------ARRAYS-----------------------------------
            //BUILDING ARRAY
            /* string[] summerStrut;
            summerStrut = new string[] {"Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
            int[] ratings = {5, 2, 4, 1, 3, 5, 1, 2}; */
            
            //ARRAY LENGTH
            /* string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            if(summerStrut.Length == 8)
            {
                Console.WriteLine("summerStrut Playlist is ready to go!");
            }
            else if(summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add some songs!");
            } */

            //ACCESSING ARRAY ITEMS
            /* string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" }; 
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };  
            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars."); */

            //EDITING ARRAYS
            /* string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };   
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };       
            summerStrut[7] = "I Like It";
            ratings[7] = 2; */

            //SORT, INDEX OF, AND FIND
            /* string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };       
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            int three = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {three + 1} is rated 3 stars.");
            string ten = Array.Find(summerStrut, song => song.Length > 10);
            Console.WriteLine($"The first song that has more that 10 characters in the title is {ten}");
            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[7]); */

            //COPY, REVERSE, AND CLEAR
            /* string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };       
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            string[] summerStrutCopy = new string[8];
            Array.Copy(summerStrut, summerStrutCopy, 8);
            Console.WriteLine(summerStrutCopy[0]);  
            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[7]);
            Array.Clear(ratings, 0 ,ratings.Length);
            Console.WriteLine(ratings[0]); */


            //---------------------------LOOPS---------------------------------------
            //WHILE LOOP    
            /* int emails = 20;  
            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"one email deleted, {emails} left");
            }
            Console.WriteLine("INBOX ZERO ACHIEVED!"); */

            //DO WHILE LOOP
            /* bool buttonClick = true;
            do
            {
                Console.WriteLine("BLARRRRRRRRR");
            } while (!buttonClick); 
            Console.WriteLine("Time for a five minute break"); */

            //FOR LOOP
            /* for (int i = 1; i < 17; i++)
            {
                CreateTemplate(i);
            } */

            //FOREACH LOOP
            /* string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
            foreach(string lists in todo)
            {
                CreateTodoItem(lists);
            } */

            //JUMP STATEMENTS
                //BREAK
                /* bool buttonClick = false;
                int counter = 0;
                do
                {
                    Console.WriteLine("BLARRRRR");
                    counter++;
                    if(counter == 3)
                    {
                    break;
                    }      
                } while(!buttonClick); */

                //CONTINUE
                /* int bats = 10;
                for (int i = 0; i <= 10; i++)
                {
                if (i < 9)
                {  
                    continue;
                }
                Console.WriteLine(i);
                } */

                //RETURN
                /* bool result = UnlockDoor();
                Console.WriteLine(result); */
    



         /*    Console.ReadKey();
        } */
        /* static void CreateTemplate(int week)     //FOR LOOP
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        } */

        /* static void CreateTodoItem(string item)     //FOREACH LOOP
        {
            Console.WriteLine($"[] {item}");
        } */

        /* static bool UnlockDoor()     //RETURN JUMP STATEMENT
        {
            bool doorIsLocked = true;
            while (doorIsLocked)    // this code will keep running
            {
                bool keyFound = TryKey(); // eventually if this stopping condition is true, it will break out of the while loop
                if (keyFound)
                {
                return true;    // this return statement will break out of the entire method
                }
            }
            return false;
        }
        static bool TryKey()
        {
            return true;
        } */


        //-----------------------------------------------------CHAPTER 6----------------------------------------------------------------------
        //CLASSES AND OBJECTS
        /* static void Main(string[] args)
        { */
            //------------------------BASIC CLASSES AND OBJECTS--------------------------------
            //MAKING CLASSES
            /* Forest f = new Forest(); */

            //FIELDS
            /* Forest f = new Forest();
            f.name = "Congo";
            f.trees = 0;
            f.age = 0;
            f.biome = "Tropical"; 
            Console.WriteLine(f.name); */

            //PROPERTIES________AND________AUTOMATIC PROPERTIES__________AND PUBLIC AND PRIVATE ACCESS MODIFIERS
            /* Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.age = 0;
            f.Biome = "Tropically";     // biome CANNOT BE DIRECTLY ACCESSED BUT Biome CAN BE
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome); */

            //GET ONLY PROPERTIES
            /* Forest f = new Forest();
            //f.Age = 0;        //CANNOT BE SET FROM MAIN()
            Console.WriteLine(f.Age);   //BUT CAN BE GET */

            //METHODS IN CLASS
            /* Forest f = new Forest();
            f.Trees = 0;
            f.Age = 20;
            Console.WriteLine(f.Age);
            Console.WriteLine(f.Trees);
            int num = f.Grow();
            Console.WriteLine(f.Age);
            Console.WriteLine(f.Trees);
            Console.WriteLine(num); */

            //CONSTRUCTORS
            /* Forest f = new Forest("Congo", "Tropical"); 
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            Console.WriteLine(f.Age); */

            //CONSTRUCTOR OVERLOADING
            /* Forest f = new Forest("Congo", "Tropical");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            Forest r = new Forest("Rendlesham");
            Console.WriteLine(r.Name);
            Console.WriteLine(r.Biome); */


            //-----------------------STATIC MEMBERS-----------------
            //STATIC FIELD, METHOD, PROPERTIES, CONSTRUCTOR
            /* Forest.PrintTreeFacts(); */

            //ARGUMENTS IN MAIN
            /* if (args.Length > 0)        //RUN THIS CODE IN TERMINAL AS dotnet run mango pineapple lichee
            {
                string mainPhrase = String.Join(" and ", args);
                Console.WriteLine($"My favorite fruits are {mainPhrase}!");
            } */
         /*    Console.ReadKey();
        } */

        //-------------------------------------------------------CHAPTER 7--------------------------------------------------------------------
        //INTERFACES AND INHERITANCE
        /* static void Main(string[] args)
        { */
            //------------------INTERFACES-----------------------------
            /* Sedan s1 = new Sedan(60);
            Sedan s2 = new Sedan(70);
            Truck t = new Truck(45, 500);

            Console.WriteLine(s1.Speed + " " + s1.Wheels + " " + s1.LicensePlate);
            Console.WriteLine(s2.Speed + " " + s2.Wheels + " " + s2.LicensePlate);
            Console.WriteLine(t.Speed + " " + t.Wheels + " " + t.LicensePlate);

            s1.SpeedUp();
            s2.SpeedUp();
            t.SpeedUp();

            Console.WriteLine(s1.Speed);
            Console.WriteLine(s2.Speed);
            Console.WriteLine(t.Speed); */

            //-----------INHERITANCE-----------------------------------------
            /* Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());
            
            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());
            
            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe()); */

        /*     Console.ReadKey();
        } */

        //-------------------------------------------------------CHAPTER 8--------------------------------------------------------------------------
        //REFERENCE
        /* static void Main(string[] args)
        { */
            //----------------------------REFERENCE FUNDAMENTALS-----------------------------------
            //REFERENCE OF SAME TYPE
            /* Diary dy1 = new Diary(5);
            Diary dy2 = dy1;
            dy2.Flip();
            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage); */

            //REFERENCE VS VALUE
            /* Book bookLocation = new Book();
            Book sameBookLocation = bookLocation;
            bool falseValue = false;
            bool anotherFalseValue = falseValue;
            Console.WriteLine(sameBookLocation);
            Console.WriteLine(anotherFalseValue); */

            //REFERENCE VS VALUE COMPARISION
            /* Book b1 = new Book();
            Book b2 = b1;
            Console.WriteLine(b1 == b2); //COMPARES THE MEMORY LOCATION IF ITS TRUE OR NOT RATHER THAN THE VALUE IT HOLD FOR THE CASE OF REFERENCE TYPE */

            //REFERENCE OF DIFFERENT TYPES
            /* Dissertation diss = new Dissertation();
			IFlippable fdiss = diss;
            Book bdiss = diss;
            fdiss.CurrentPage = 42;
            bdiss.Stringify();
            Console.WriteLine(fdiss == bdiss); */

            //ARRAYS OF REFERENCE
            /* Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
			Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
			Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
			Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");
            Book[] books = new Book[] {diss1,  diss2,  dy1,  dy2};
            foreach (Book b in books)
            {
                Console.WriteLine(b.Title);
            } */

            //POLYMORPHISM
            /* Book b1 = new Book();
            Book b2 = new Diary();
            Console.WriteLine(b1.Stringify());  //CALLS METHOD OF BOOK
            Console.WriteLine(b2.Stringify());  //CALLS METHOD OF DIARY (b2 IS A REFERENCE) */

            //CASTING
            /* Dissertation diss = new Dissertation();
            Diary dy = new Diary();
            Book bdiss = diss;  //UPCASTING
            Book bdy = dy;      // REFERENCE TO SUBCLASS

            Book bk = new Book();   
            Dissertation bdk = (Dissertation)bk;    //DOWNCASTING
            Diary bd = (Diary)bk;                   //REFERENCE TO SUPERCLASS (SHOULD BE DONE EXPLICITLY) */

            //NULL AND UNASSIGNED REFERENCE
            /* Book b;                             //UNASSIGNED
            Diary[] diaries = new Diary[5];     //UNASSIGNED
            Book bk = null;                     //NULL
            Console.WriteLine(b == null);       //THROWS ERROR AS B IS NOT ASSIGEND TO NULL
            Console.WriteLine(bk);              //PRINTS NOTHING
            Console.WriteLine(bk == null);      //TRUE */

            //------------------THE OBJECT CLASS------------------------
            /* Object STANDS AT TOP OF ALL
            OBJECT LIMITS HE FUNCTIONALITY */
            //THE OBJECT TYPE
            /* Book bk = new Book();
            Diary dy = new Diary(38);    
            int i = 9;    
            Object o1 = bk;         //THIS IS POSSIBLE AS OBJECTS STANDS AT TOP OF ALL
            Object o2 = dy;        
            Object o3 = i; */

            //OBJECT MEMBERS
            /* Book b = new Book();      
            Diary d = new Diary(38);
            Random r = new Random();
            int i = 9;
            Object[] objects = { b, d, r, i };     
            foreach (Object obj in objects)
            {
                Console.WriteLine(obj.GetType());       //RETURNS THE TYPE OF OBJECT
                Console.WriteLine(obj.ToString());      //RETURNS A STRING DESCRIBING THE OBJECT
            }
            Object o2 = objects;
            Console.WriteLine(objects.Equals(o2));      //COMPARES OBJECTS */

            //OVERRIDING OBJECT MEMBERS
            /* Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
            Console.WriteLine(bk.ToString()); */

            // ToString() IMPLICITLY RUN ON Console.WriteLine()
            /* Diary d = new Diary();
            Console.WriteLine(d);
            Console.WriteLine(d.ToString()); */

            //-------------------------STRING, THE EXCEPTION------------------------
            //STRING CAN LOOK LIKE VALUES
            /* string s1 = "immutable";
            string s2 = "immutable";
            Console.WriteLine(s1 == s2);

            Object o1 = new Object();
            Object o2 = new Object();
            Console.WriteLine(o1 == o2); */

            //STRING CAN BE NULL OR EMPTY OR UNASSIGNED
            /* // Unassigned
            string s;
            // Null
            string s2 = null;
            // Empty string
            string s3 = "";
            // Also empty string
            string s4 = String.Empty;
            // This prints true
            Console.WriteLine(s3 == s4); */

            //PRACTICE
            /* Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("You didn't enter anything!");
            }
            else
            {
                Console.WriteLine("Thank you for your submission!");
            } */

            //REPLACE METHOD
            /* string lyrics = 
                "Dollie, Dollie, bo-bollie,\n" +
                "Banana-fana fo-follie\n" +
                "Fee-fi-mo-mollie\n" +
                "Dollie!";
            lyrics = lyrics.Replace("ollie" , "ana");
            Console.WriteLine(lyrics); */


         /*    Console.ReadKey();
        } */


        //-------------------------------------------------------CHAPTER 9-----------------------------------------------------------------------------
        //LISTS AND LINQ
        static void Main()
        {
            //----------------------------LISTS--------------------------------------
            //CREATING AND ADDING
            /* List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);
            Console.WriteLine(marathons[1]);  //INDEC STARTS FROM 0 */

            //OBJECT INITIALIZATION
            /* List<double> marathons = new List<double> {144.07, 143.12, 146.73, 146.33};
            double time = marathons[1];
            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!"); */

            //COUNT AND CONTAINS
            /* List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };
            Console.WriteLine(marathons.Count);
            marathons.Add(143.23);
            Console.WriteLine(marathons.Contains(143.23));
            Console.WriteLine(marathons.Count); */

            //REMOVING
            /* List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };
            Console.WriteLine(marathons[1]);
            bool removed = marathons.Remove(143.12);
            Console.WriteLine(marathons[1]);
            Console.WriteLine(removed); */

            //CLEARING
            /* List<double> marathons = new List<double>
            {
                148.22,
                156.10,
                153.88,
                155.34,
                160.89
            };
            marathons.Clear();      //CLEAR LIST
            Console.WriteLine($"Count: {marathons.Count}"); */

            //WORKING WITH RANGE
            /* List<string> places = new List<string> { "first", "second" };
            places.AddRange(new string[] { "fifth", "sixth" });             // List is  "first", "second", "fifth", "sixth" ]     
            places.InsertRange(2, new string[] { "third", "fourth"});       // List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]          
            places.RemoveRange(4, 2);                                       // List is [ "first", "second", "third", "fourth" ]    
            List<string> newPlaces = places.GetRange(0, 3);                 // New list is [ "first", "second", "third" ] */

            //LOOPING THROUGH LISTS
            /* List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            Random rand = new Random();  
            Console.WriteLine("In reverse chronological order, the gold medalists are...");
            for (int i = 0; i < runners.Count; i++)         //USED IF WE NEED TO PRINT NUMBERS/ IF COUNT IS NEEDED TO PRINT
            {
                Console.WriteLine($"{i+1}: {runners[i]}");
            }         
            Console.WriteLine("\nPrinting runner bibs...");
            foreach (string s in runners)                   //MOSTLY USED
            {
                string name = s.ToUpper();
                int id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {name}");
            } */

            //GENERIC COLLECTIONS
            /* List<bool> list1 = new List<bool>();
            List<Random> list2 = new List<Random>();
            List<IServiceProvider> list3 = new List<IServiceProvider>(); */


            //------------------------------------LINQ---------------------------------------------
            //USING VAR
            /* List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var shortHeroes = from h in heroes                  //USE OF LINQ
                                where h.Length < 8
                                select h;
            foreach (var v in shortHeroes)
            {
                Console.WriteLine(v);
            }
            var longHeroes = heroes.Where(n => n.Length > 8);       //USE OF LINQ
            Console.WriteLine(longHeroes.Count()); */

            //QUERY AND METHOD SYNTAX----------------
            //BASIC QUERY SYNTAX
            /* string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var heroesWithI = from h in heroes
                                where h.Contains("i")
                                select h;
            var underscored = from hero in heroes
                                select hero.Replace(" ", "_"); */

            
            //BASIC METHOD SYNTAX :     .WHERE
            /* string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var heroesWithI = heroes.Where(h => h.Contains("i"));
            foreach (var hero in heroesWithI)
            {
                Console.WriteLine(hero);
            } */

            //BASIC METHOD SYNTAX :     .SELECT
            /* string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var heroesWithC = heroes.Where(h => h.Contains("c"));               //CAN BE WRITTEN SEPERATELY
            var lowerHeroesWithC = heroesWithC.Select(h => h.ToLower());        //CAN BE WRITTEN IN ONE LINE
            var sameResult = heroes
                .Where(h => h.Contains("c"))
                .Select(h => h.ToLower());
            foreach (var hero in sameResult)
            {
                Console.WriteLine(hero);
            } */

            //WHEN TO USE EACH SYNTAX   
            /* string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var transformHeroes = heroes.Select(h => $"Introducing...{h}!");        //FOR SINGLE OPERATOR, USE METHOD SYNTAX
            var containSpace = from hero in heroes                                  //FOR EVERYTHING ELSE, USE QUERY SYNTAX
                    where hero.Contains(" ")
                    select hero.IndexOf(" ");
            foreach (var h in transformHeroes)
            {
                Console.WriteLine(h);
            }
            foreach (var h in containSpace)
            {
                Console.WriteLine(h);
            } */

            //LINQ WITH LIST
            /* List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
            var hero = heroesList.Where(h => h.Contains(".") || h.Contains("7"));
            foreach (var h in hero)
            {
                Console.WriteLine(h);
            } */

            Console.ReadKey();
        }
    }
} 

