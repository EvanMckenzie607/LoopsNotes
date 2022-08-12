using System;
using LoopsNotes;

//***LOOP NOTES AKA. ITERATION STATEMENTS***

#region//WHY??------
//In real life we need to do some repetive tasks
//and doing the same task again and again can be hectic.
//There are situations where you have to write a statement
//or exucute a set of logic multiple times or display a
//message with a slight variation in numbers.
//So obviously doing this form of work manually will be 
//time consuming and extremly ineffective
#endregion

//There are 4 differnt loops:
//while
//do-while
//for
//foreach
#region WHILE LOOP

//***while***
//The "while" loop executes a statement or a block of statements while
//a specified Boolean expression evaluates to true.
//Because that expression is evaluated before each execution 
//of the loop, a "while" loop exucutes zero or more time.
//This differs fro, the "do-while" loop which executes one or more times.
//Use a "while" loop if you need to execute some code until something happens.
//var x = 5;
//var y = 6;
//while (x < y)
//{
//    y = x + 2;
//    Console.WriteLine($"{y} is not less than {x}");
//    y = x - 5; //Without this false statement the loop will run forever(infinite)
//    Console.WriteLine($"{y} is less than {x}"); 
//}

#endregion

#region DO-WHILE LOOP
//***do-while***
//The "do-while" loop exucutes a statement or a block of statements
//while a specified Boolean expression evaluates to true.
//Because that expression is evaluated after each execution of the loop
//a "do-while" loop is guaarenteed to execue at least one or more times.
//use a "do-while" loopif you need to execute some code at least once
//then continue execution until something happens.

//var i = 0;
//do
//{
//    i++; //Increments "i" each execution (adds 1 to the int)
//Console.WriteLine($"{i} is less than 10");
//} while (i < 9);
//Console.WriteLine($"{++i} is equal to 10");

#endregion

#region FOR LOOP
//***for***
//The "for" loop executes a statement or a bloack of statements
//while a specified Boolean expression evaluates to true.
//Use a "for" loop if you need to execute some code a specific number of times.
//A "for" loop contains 5 parts:

//The "for" keyword
//for

//The "initializer" - runs once at the beginning and sets an
//initial value to serve as a counter
// int i = 0;

//The "conditinal" - evaluates before each iteration to determine
//whether the loop should continue executing
// i < 10;

//The "increment" - after the body of the loop is executed
//the increment updates the value of the counter
// i++;

//The "body" - the body is the block of code the loop will execute.
//We also call this the scope of the loop
//{
//  "code here"
//
//}
//var i = 10;
//#1        #2            #3          #4
//for(initializer; conditional; increment)
//{
//     #5 Body of the loop
//}
//Below we initialize a counter name "i" to 0.
//While i less than 5 the loop will execute the body of the loop
//and after each time we execute the body of the loop we increment "i" by 1

//for (int i = 0; i <= 25; i += 1) //<= allows system to print to 25
//                                 //   Because c# is a 0 based index system
//{
//    Console.WriteLine(i);
//}

//All three main sections are optional. The body of the loop is either a
//statement or a block of statements.
//Below lets look at the way a "for" loop executes

//var listofnumber = new List<int>();  // Create a break here and step out
//for (int i = 1; i <= 10; i++)           to see it in action                                        
//{
//    listofnumber.Add(i);
//    Console.WriteLine($"{i}");
//}

#endregion

#region FOREACH LOOP
//***foreach***
//A "foreach" loop executes a statement or a block of statements
//for each element in an instance of the type that implements the
//System.Collections.IEnumerable;

//In other words, a "foreach" loop is ued to iterate through 
//collections such as: Arrays[] or <lists>

//The "foreach" loop is ued for iterating over a collection.
//The "foreach" loop is simular to a for loop.
//The syntax is easier to read is is perferable in many
//scenarios when you have a collection.
//Use a "foreach" loop if you need to execute some code on 
//each elemnt in a acollection of elements.

//EXAMPLE BELOW

//var ourCandyBag = new string[] { "snickers", "reeses", "milky-way", "candy-corn" };
//foreach(var pieceOfCandy in ourCandyBag)
//{
//    if(pieceOfCandy == "candy-corn") //---> collection of items
//    {
//        Console.WriteLine($"Boo! Wax and sugar!");
//    }
//    else
//    {
//        Console.WriteLine($"WOWZA {pieceOfCandy}! Delicious!");
//    }
//}
#endregion

#region HOW:
//Code Examples of each below

//"do-while" loop

Console.WriteLine(LoopExamples.Deposit);

#endregion