// Program name: Student Ticket Application
// Program purpose: Create a program to provide the user with the value of the speeding ticket
// Program author: [Luis Rodriguez]
// Date and time started:  2022- 03- 12  at 0832
// Date and time ended:    2022- 03- 25  at 1545
// Start time: 0832 - 2022 03 12
// End time: 1545 - 2022 03 25
// Hours to build program : 7 hours 57 mins  ( taking breaks and going back into it, roughly took 8 hours)
// I started with the README.txt to map all things out then on the 24th of March I started to code on the CS
// Date last modified: 2022-03-25




using System;    

class Program
{
static void Main()
{
                                        //For version 3       start:  0832 2022-03-12
   /*  // Getting input from user
    Console.WriteLine("\tWelcome to the Student Ticket Application.");       // Welcoming statement for the user / student
    Console.WriteLine("\nPlease enter your first name: ");                  // courtesy to mention the students name or the users name
    string firstName = Console.ReadLine();                                 // string the first name of the user to use later for the output
    Console.WriteLine("Please enter your last name: ");                   // courtesy to ask for the last name , I feel it defines a person. This input will be used for the output
    string lastName = Console.ReadLine();                                // user will input their last name which will be used for the output at the end of the program.
    Console.Write("\nSalutations " + firstName + " " + lastName);       // salutations for the user. Also adding his or her first and last name. */

                                      //For version 3
       
       // Starting Version 1    Time: 0930 = 2022 03 24
       // Declaring the variables              

int yrInSchool;             // for the year in school :  student year in school
int speed;                 // this will be speedTraveling - speedLimit. The difference between the speedTraveling and the speedLimit
int speedLimit;          // the variable for the speedlimit will be inputed
int speedTraveling;     // variable for the speedTraveling will also be inputed by the user
double totalCost;         // decimal value for the Grand total of the ticket
    
//time: 0953 = 2022 03 24

    Console.Write(" Please Enter your Student Number: ");                // input of student number to use for the end of the Program where it lists off the information for the student
    string studentNumber = Console.ReadLine();                          // readline used to save whatever the input is from the user / student  using string for studentNumber
     
    Console.Write("\nEnter the Speed Limit: ");                       // asking for user to input the speed limit of the road
    speedLimit = Convert.ToInt32(Console.ReadLine());                // input will retrieve the number I need for the calculation below : speedLimit and converting to integer
    Console.Write("Enter the Ticketed Speed: ");                    // asking user for input of the speed they were traveling
    speedTraveling = Convert.ToInt32(Console.ReadLine());          // input will retrieve the number I need for the calculation below : speedTraveling and converting to integer
    Console.WriteLine("Enter the number to your corresponding class: ");     // this will help me get the YrInSchool from the user so I can use it for the calculation later on.
    Console.WriteLine("\tFreshman <enter 1>");                              // if the user is a freshman he will input 1      
    Console.WriteLine("\tSophomore <enter 2>");                            // if the user is a sophomore he will input 2
    Console.WriteLine("\tJunior <enter 3>");                              // if the user is a junior he will input 3
    Console.WriteLine("\tSenior <enter 4>");                             // if the user is a senior he will input 4
    yrInSchool = Convert.ToInt32(Console.ReadLine());                   // yrInSchool converting to integer from the input of the user

    //Time: 1104 2022 03 24

    Console.WriteLine("");    //for spacing and legibility but not really necessary
    
    
    Console.WriteLine("\nPlease Write out your classification: ");       // input class :  Freshman , sophmore , Junior , or senior
    Console.WriteLine("\tFreshman");                              // spacing out lines for readability :  freshman is the first option
    Console.WriteLine("\tSophomore");                            // spacing out lines for readability: sophomore being the second option
    Console.WriteLine("\tJunior");                              // spacing out lines for readability: Junior being the third option
    Console.WriteLine("\tSenior");                             // spacing out lines for readability: Senior being the fourth option
    string classif = Console.ReadLine();                        // the input from the user will provide us with a save point of the data inputted. 
   
   
   

//Time: 1400 2022 03 24

    // calculations part 1
speed = speedTraveling - speedLimit;                   // calculation done here after the int were all declared. Good spot to put it after I see how everything is going to be presented.

totalCost = TicketCost(yrInSchool, speed);           // the totalCost will be affected by the yrinschool and the speed which is under the TicketCost. 1 reference for the "public static double TicketCost"

//OUTPUT for user
Console.WriteLine("\n\n\tTicket App");                                      // title of program . This will show to the user when He gets the output of the program
Console.WriteLine("\nStudent ID:  " + studentNumber);                      // studentNumber will now be displayed for the user

/* Console.WriteLine("Classification Year:  " + yrInSchool);             // Year in school will now be displayed for the user:  ( 1 - 2 - 3 - 4 ) */    // for version 3

Console.WriteLine("Classification:  " + classif);                       // classification : (freshman - Sophomore - Junior - Senior)
Console.WriteLine("Speed Limit:  "+ speedLimit);                       // Speed Limit will be displayed so the user can see the speed limit
Console.WriteLine("Reported Speed:  " + speedTraveling);              // Speed the user was traveling on the speed limit road
Console.WriteLine("\n\nFine $" + totalCost);                           // Total cost of the ticket with all calculations done






//Time: 1632 2022 03 24

/* Console.Write("\nThank you " + firstName + " " + lastName);          // courtesy to mention the users first and last name and of course thanking them for using the program */  //for version 3
/* Console.Write(" for using the speed ticket application!");          // using "Write"  to put the sentence all together again just a courtesy message to the user */   //for version 3
/* Console.Write(" Remember to Slow Down and Drive safe!");           // using "Write" instead of "WriteLine" to put the sentence together and a little reminder to be safe */   //for version 3
// program output ends here 

}

//second part of program split due to different calculations and usage of methods and conventions
 // --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 

//Time: 0801 2022 03 25

public static double TicketCost                // double for the decimal which will be worked with when using money. (ie:  $5.25)   this will be the section for calculations. For returndot

(int yrInSchool,                             // yrInSchool will be used along with int speed for the formula given

 int speed     )                            // variables being used in this public static  re-declared for this side of the program

// calculations part 2
{
double setFine = 0.0;                       // declaring another important variable setting it with double. Will be dealing with decimals in this equation especially with money.
{
setFine = 75.00;                        // initial fee will be the setFine it will have to be decimal or double to deal with the equation with decimals.

int fine = speed / 5;                 // split equation up so that I could use one part for integers and the other part for double or decimals. Since fine is a whole number with speed.
setFine = setFine + fine * 87.50;    // split up the second part of the equation to use the decimal "double" since setFine is a decimal and the "* 87.50" is also a decimal.
                                    // splitting up the equation helps me to manuever the decimal and int rule.
if (yrInSchool == 4 )                // Year in school = 4 which is senior this is the start of the seniors calculations
{
    if(speed > 20)
    setFine = setFine + 200;               // setFine + 200 if more than 20kph over speed limit

    else
    setFine = setFine + 50;             // seniors should know better by now so they get expensive add on charges
}
else                                  // this "else" will be used for freshman
{
    if (yrInSchool == 1)            // year in school = freshman since 1 = freshman 
{
    if (speed<20)                  // if speed is lesser than 20 - 50 to the setFine

    setFine = setFine - 50;     // since its their first year we subtract 50 from the setFine

    else

    setFine = setFine +100;    // if speed is not lesser than 20 then +100 to the setFine
}                 
else if (speed > 19)         // this else if will be used for freshman, sophomores, and juniors if speed is greater than 19 setfine+100

setFine = setFine + 100;  
  
}
  
}
return setFine;        // returning set fine for the TicketCost
}
}


                    // program END at 2022 - 03- 24 @ the time of 1200 PM will now go do desk checks and post on the README.TXT