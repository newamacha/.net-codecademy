//INTERFACE
using System;

namespace sanam_maharjan
{
    class Forest
    {
        //FIELDS
        /* public string name;
        public int trees;
        public int age;
        public string biome; */

        //PROPERTIES
        /* public string name;
        public int trees;
        public int age;
        public string biome; 
        public string Name
        {
            get { return name; }
            set { name = value; }
        } 
        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        } 
        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        } */

        //AUTOMATIC PROPERTIES (ONLY FOR SPECIFIC COMMAND => TO GET AND TO SET)
        /* public int age;
        public string biome;  
        public string Name
        {get; set; }         //AUTOMATIC PROPERTIES
        public int Trees
        {get; set; }          //AUTOMATIC PROPERTIES
        public string Biome
        {
            get { return biome; }   //AUTOMATIC PROPERTIES NOT POSSIBLE
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        } */

        //PUBLIC AND PRIVATE ACCESS MODIFIERS
        /* public int age;
        private string biome;
        public string Name
        { get; set; }
        public int Trees
        { get; set; } 
        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        } */

        //GET ONLY PROPERTIES
        /* public int age = 10;
        public int Age
        {
            get{ return age; }
            private set {age = value; }
        } */

        //METHODS IN CLASS
        /* public int age;
        public int Trees
        { get; set; }  
        public int Age
        { 
            get { return age; }
            set { age = value; }
        }
        public int Grow()
        {
            Trees = Trees + 30;
            Age = Age + 1;
            return Trees;
        } */

        //CONSTRUCTORS
        /* public int age;
        private string biome;  
        public string Name
        { get; set; } 
        public string Biome
        { get; set; }
        public int Age
        { 
            get { return age; }
            private set { age = value; }
        }
        public Forest( string name, string biome)
        {
            Name= name;
            Biome = biome;
            Age = 0;
        } */

        //CONSTRUCTOR OVERLOADING
        /* private string biome; 
        public string Name
        { get; set; }    
        public Forest(string name, string biome)
        {
            this.Name = name;       //THIS PROPERTY
            this.Biome = biome;     //THIS PROPERTY
        }
        public Forest(string name) : this(name, "Unknown")  //EVEN THOUGH ONE PARAMETER IS ASSIGNED, VALUES ARE CHANGED IN BOTH
         //HERE, THIS PROPERTY HELPS TO LINK THIS CONSTRUCTOR WITH THE FIRST CONSTRUCTOR
        {
            Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
        }  
        public string Biome
        { get; set;} */

        //STATIC MEMBERS
            /* // FIELDS
            private static int forestsCreated;
            private static string treeFacts;
            
            // CONSTRUCTORS
            static Forest()     //NO ACCESS MODIFIERS REQUIRED
            {
                treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
                ForestsCreated = 0;
            }
            
            // PROPERTIES
            public static int ForestsCreated
            {
                get { return forestsCreated; }
                private set { forestsCreated = value; }
            }
            public static string TreeFacts
            {
                get { return treeFacts; }
            }
            
            // METHODS
            public static void PrintTreeFacts()
            {
                Console.WriteLine(TreeFacts);
            } */

        
    }
}
