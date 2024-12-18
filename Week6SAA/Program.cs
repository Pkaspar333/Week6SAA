//Console.WriteLine("Enter your first name:");
//string userName  = Console.ReadLine().Trim();
string userName = "Dark Vader";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");

//Console.WriteLine(userName[0]);
//Console.WriteLine(userName[1]);
//Console.WriteLine(userName[2]);
//Console.WriteLine(userName[3]);
//Console.WriteLine(userName[4]);

//int counter = 0;

//for (int i = 0; i < userName.Length; i++)
//{
//    if (userName[i] == a)
//    { 
//        counter++; //counter = counter + 1
//    }
//}

//Console.WriteLine($"Your first name has {counter} a-letters.");

string updatedUserName = userName.Replace('a', '4').Replace('e', '3');

Console.WriteLine(updatedUserName);