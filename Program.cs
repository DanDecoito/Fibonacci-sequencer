Console.Clear();
string terminateGame = ".";
bool parseCheck = true;
bool parseBool = false;
int x = 0;

while (terminateGame != "")
{
          
while (parseBool == false)
{    
     
     Console.WriteLine("  Fibinachi Sequence Generator\nEnter a number for sequence length.");
     Console.WriteLine("  or press \"enter\" to quit");

     string userInput = Console.ReadLine();
     if (userInput == "")
     {
          terminateGame = "";
          break;
          
     }
     parseBool = int.TryParse(userInput, out x);
     if (parseBool == false)
     {     Console.Clear();
          Console.WriteLine("\n------->Incorrect input<--------\n");
     }
    
}
Console.Clear();
 
int mathOne = 0;
int mathTwo= 1;
int maths = 0;
Console.WriteLine();
for (int i = 0; i < x ; i++)
{
     maths  = mathOne + mathTwo;
     mathOne = mathTwo;
     mathTwo = maths;
     
Console.Write($" {maths},");
}
Console.WriteLine("\n");

x = 0;
parseBool = false;
}





