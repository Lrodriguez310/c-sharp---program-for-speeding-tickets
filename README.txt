Program name: Student Ticket Application
program purpose: Create a program to provide the user with the value of the speeding ticket
Program author: [Luis Rodriguez]
Date and time started:  2022- 03- 12  at 0832
Start time: 0832 - 2022 03 12
End time:   1545 - 2022 03 25
Hours to build program : 7 hours 12 mins
Date last modified: 2022-03-25


Start time: 0832 - 2022 03 12
End time:   1545 - 2022 03 25

THE ROBUST README:

I tried my best with the limited knowledge I have about programming. I struggled very much and tried and tried to make the identifiers work. I then
found other ways to still display the program as requested by the employer. 

I struggled using Char and couldnt convert the yrinSchool char into a char classif which is I assume an entire word (Fresh, soph, junior, senior)
I tried to have the inValue string as the combiner but failed to do so. 

The program still works very well after a lot of desk checking.

Writing an application for this scenario:

    Consider the situation of issuing a parking ticket on campus and determining the fines associated with the ticker.

    All students are charged an initial $75.00 when ticketed.
    Additional charges are based on how much over the speed limit the ticket reads.
    There is a 35 KPH speed limit  on most streets on campus.
    Two roads have a speed limit of 15 KPH.
    After the initial fee an extra $87.50 is charged for every 5KPH.
    seniors have more fee's added to their fines.
    freshmen get a little slack
    seniors are charged an extra $50 when they get caught speeding.
    If seniors are traveling more than 20KPH they they are charged an extra $200
    If freshmen are exceeding the speed limit by less than 30KPH, they get $50 deducted off their fines.
    Freshmen , sophomores, and Juniors travelling 20 KPH or more are fined an additional $100.



Time: 0840 - 2022 03 12

started out thinking about how I could make this program work. I was given the start ups but still struggling to figure out how
to put it all together. I will start with a welcoming statement that allows the user to feel somewhat important while using my program.
Console.WriteLine("\tWelcome to the Student Ticket Application.");

Time: 0845 - 2022 03 12  

I will start by displaying the users name and last name. He will input and declare these two strings firstName + lastName.
This will give me a good sense of direction in the way I will build the program. First the program will interact with the user.
asking for his or her name. Always good to be polite to the user.

Time: 0900 - 2022 03 12

Next step is acquiring the users student ID number. The string that I will need for the final output at the end of the program. String will 
be named studentNumber.

Time: 0832 - 2022 03 13

Checked the program to see that everything is running well. Now I will begin by declaring the variables which will be used in the 
program.

Time: 0850 - 2022 03 13

Variables for version 3:

Time: 0857 - 2022 03 13

string firstName = given name - acquired by user input
    Console.WriteLine("\nPlease enter your first name: ");                  
    string firstName = Console.ReadLine(); 

Time: 0910 - 2022 03 13

string lastName  = family name - acquired by user input
    Console.WriteLine("Please enter your last name: ");                   
    string lastName = Console.ReadLine();

This will produce a welcome message with the users first and last name 
Console.Write("\nSalutations " + firstName + " " + lastName);

Time: 0922 - 2022 03 13

string studentNumber = student ID will be acquired by user input
    Console.Write(" Please Enter your Student Number: ");             
    string studentNumber = Console.ReadLine();
----------------------------------------------------------------------------------------------

Time: 1055 - 2022 03 14



declaring variables :

\n = next line
\t = Tab for better legibility 

int yrInSchool    = the year of the class the student is attending. I will need this for the formula.  User must input        
int speed          =  speed will equal speedTraveling - speedLimit 
string inValue     = used to obtain the users input and will be able to convert the readline to char      
double totalCost   = total cost will need a double for the use of money. 

Time: 1104 - 2022 03 14

int speedLimit     =  speed limit will either be 35 or 15 depending on the road they are traveling in. user must input        
int speedTraveling =  this integer will acquire the speed the student was traveling. User must input
string classif     =  classification this will be used to acquire the users class ( freshman , sophomore, junior, or senior) user must input
double setFine     = this will be used to represent the set fine of $75.00 which is the initial charge. double used for decimal values
int Fine           = this will be used to represent part of the formula :  int fine = speed / 5;  setFine = setFine + fine * 87.50;  I divided in two since one deals with decimals and the other deals with integers.
speed              = speedTraveling - speedLimit;


Time: 1503 - 2022 03 15

Moving on to how I will obtain these inputs from the user.

Time: 1542 - 2022 03 15

user inputs:

The employer wants the program to look a certain way and structured in a specific way.
I will ask for the input of the user in the way the employer wants it done.


Time: 0133 - 2022 03 16  ---  its LATE!

I will acquire the student ID first or the string studentNumber:

Console.Write(" Please Enter your Student Number: ");                
string studentNumber = Console.ReadLine(); 

Time: 0245 - 2022 03 16 ---- its really late o_o      

Then I will acquire the speed limit or the int speedLimit:

Console.Write("\nEnter the Speed Limit: ");                       
speedLimit = Convert.ToInt32(Console.ReadLine());


Time: 1206 - 2022 03 17

Then I will acquire the ticketed speed or int speedTraveling:

Console.Write("Enter the Ticketed Speed: ");                    
speedTraveling = Convert.ToInt32(Console.ReadLine());

Time: 1308 - 2022 03 17

I will now acquire the students classification year here or yrInschool:

Console.WriteLine("Enter the number to your corresponding class: ");     
    Console.WriteLine("\tFreshman <enter 1>");                                   
    Console.WriteLine("\tSophomore <enter 2>");                            
    Console.WriteLine("\tJunior <enter 3>");                              
    Console.WriteLine("\tSenior <enter 4>");                             
    yrInSchool = Convert.ToInt32(Console.ReadLine()); 

Time : 1601 - 2022 03 18

To acquire the classification ( freshman , sophomore, junior , and senior) I will use this prompt to acquire the string:

  Console.WriteLine("\nPlease Write out your classification: ");       // input class :  Freshman , sophmore , Junior , or senior
    Console.WriteLine("\tFreshman");                              // spacing out lines for readability :  freshman is the first option
    Console.WriteLine("\tSophomore");                            // spacing out lines for readability: sophomore being the second option
    Console.WriteLine("\tJunior");                              // spacing out lines for readability: Junior being the third option
    Console.WriteLine("\tSenior");                             // spacing out lines for readability: Senior being the fourth option
    string classif = Console.ReadLine();                        // the input from the user will provide us with a save point of the data inputted. 


Time: 1835 - 2022 03 19


    Output for user:

    The output for the user should look like this:

        Ticket App

student number: xxxxxx

classification: xxxxxx

speed limit: xx

reported speed: xx



Fine: $xxx



Time: 1700 - 2022 03 21  -- skipped a day but still had the program on my mind :)

//OUTPUT for user

I will display "Ticket App"  at the top of the output screen

Console.WriteLine("\n\n\tTicket App");                                      // title of program . This will show to the user when He gets the output of the program

followed by the Student ID number 

Console.WriteLine("\nStudent ID:  " + studentNumber);                      // studentNumber will now be displayed for the user

This will be for version 3 but I blocked it off already in the code.

Console.WriteLine("Classification Year:  " + yrInSchool);             // Year in school will now be displayed for the user:  ( 1 - 2 - 3 - 4 )  for version 3

The classification will be outputted for the user ( Freshman , Sophomore, Junior, or Senior)

Console.WriteLine("Classification:  " + classif);                       // classification : (freshman - Sophomore - Junior - Senior)

Next output will be the speed limit. I believe there are two speed limits one is 35 which I assume to be the main road and the other being 12 kph which is an off road I assume.

Console.WriteLine("Speed Limit:  "+ speedLimit);                       // Speed Limit will be displayed so the user can see the speed limit

I will now output the users ticketed speed. This is so that the user can view the speed limit and the speed he/she was traveling.

Console.WriteLine("Reported Speed:  " + speedTraveling);              // Speed the user was traveling on the speed limit road

I will also need to output the final cost or the grand total aka totalCost. This will be the formula and sum of all fines and charges.

Console.WriteLine("\n\nFine $" + totalCost);                           // Total cost of the ticket with all calculations done


Time 1900 - 2022 - 03 - 21

for spacing:

Console.WriteLine();




Time: 1455 - 2022 03 22
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Equation:

I was having a lot of trouble with the formula, trying to figure out how to combine the int and the double / decimals.  So I decided to split the formula so that I can use both
functions and make it work. This took me a lot of time. I was in the shower thinking about how to make it work. So I came up with the brilliant idea to split the formula without disturbing
its main objective. I wanted it to do what it was ment to do without any errors from the program.

Time: 1632 - 2022 03 22

I decided to split it into integers and then split it into messing with decimals. The formula still works! Eureka!!

int fine = speed / 5;                 // split equation up so that I could use one part for integers and the other part for double or decimals. Since fine is a whole number with speed.
setFine = setFine + fine * 87.50;
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 
Time: 1734 - 2022 03 23 

I tried to be as creative as possible to make the program work how it should. For the Equation I had to split it up so that the decimals 
wouldn't interfere with the integers. It was tough but after trial and error I got it to work.

Formula and pseudocode for the setFine:

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

Time: 1856 - 2022 03 23   all done fixing up this code works well and is ready to be implemented.





-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


Time: 0917 = 2022 03 24   making a decision tree            

Decision tree for speeding ticket application:

                                     --> true --- fine += 200
If senior --> true ------ speed > 20 |
          |                          --> false --- fine+= 50
          --> false |
                  |               
                  |                                       --> true --- fine -= 50
                  |               --> true --- speed < 20 |
                   -> if freshman |                       --> false --- fine += 100
                                  | 
                                  --> false --- speed > 19 --- true --- fine += 100   (sophomore and juniors)

    
    Time: 1100 - 2022 - 03 - 24  lets break down the tree.
    
     Breaking down the Decision Tree:

        If senior is true then apply  if traveling speed > 20 over the speed limit then fine + 200 /  if not over the speed limit by 20 then fine + 50.
        If false senior then if freshman then if over the speed limit is below 20 then subtract 50 from fine but if not then fine + 100. 
        if false freshman then if your speed is 19 over the speed limit fine will be applied along with 100.00 more. This is for the remainder ( sophomores and juniors).
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Time: 1244 - 2022- 03- 25   Lets do some desk checks to make sure the forumla is working just right!

DESK CHECK

I will desk check using both speed limits 15 kph and the 35 kph.

speedLimit     |Ticketed speed     |yrInSchool(1= Freshman, 2= Sophomore, 3= Junior, 4= Senior)    |Fine
______________________________________________________________________________________________________________
15             20                  1                                                            =   $112.50  |    Starting with the other speed limit which in the scenario it said there was one with 15 kph
-------------------------------------------------------------------------------------------------------------|
15             25                  1                                                            =   $200.00  |
-------------------------------------------------------------------------------------------------------------|
15             35                  1                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|                                                          
-------------------------------------------------------------------------------------------------------------|
15             40                  1                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
15             20                  2                                                            =   $162.50  |
-------------------------------------------------------------------------------------------------------------|
-------------------------------------------------------------------------------------------------------------|
15             25                  2                                                            =   $250.00  |
-------------------------------------------------------------------------------------------------------------|
15             35                  2                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
-------------------------------------------------------------------------------------------------------------|
15             40                  2                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
15             20                  3                                                            =   $162.50  |
-------------------------------------------------------------------------------------------------------------|
15             25                  3                                                            =   $250.00  |
-------------------------------------------------------------------------------------------------------------|
15             30                  3                                                            =   $337.50  |
-------------------------------------------------------------------------------------------------------------|
15             40                  3                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
15             20                  4                                                            =   $212.50  |
-------------------------------------------------------------------------------------------------------------|
15             25                  4                                                            =   $300.00  |
-------------------------------------------------------------------------------------------------------------|
15             30                  4                                                            =   $387.50  |
-------------------------------------------------------------------------------------------------------------|
15             40                  4                                                            =   $712.50  |
-------------------------------------------------------------------------------------------------------------|
15             17                  4                                                            =   $125.00  |    
-------------------------------------------------------------------------------------------------------------|
15             20                  2                                                            =   $162.50  |
-------------------------------------------------------------------------------------------------------------|
15             35                  3                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
15             18                  1                                                            =   $25.00   |
-------------------------------------------------------------------------------------------------------------|
15             40                  4                                                            =   $712.50  |
-------------------------------------------------------------------------------------------------------------|
15             35                  4                                                            =   $475.00  |
-------------------------------------------------------------------------------------------------------------|
15             40                  1                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
35             42                  1                                                            =   $112.50  |
-------------------------------------------------------------------------------------------------------------|
35             55                  2                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             57                  1                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             47                  2                                                            =   $250.00  |
-------------------------------------------------------------------------------------------------------------|
35             54                  1                                                            =   $287.50  |
-------------------------------------------------------------------------------------------------------------|
35             57                  2                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             44                  4                                                            =   $212.50  |
-------------------------------------------------------------------------------------------------------------|
35             39                  4                                                            =   $125.00  |
-------------------------------------------------------------------------------------------------------------|
35             58                  4                                                            =   $625.00  |
-------------------------------------------------------------------------------------------------------------|
35             55                  4                                                            =   $475.00  |
-------------------------------------------------------------------------------------------------------------|
35             38                  1                                                            =   $25.00   |
-------------------------------------------------------------------------------------------------------------|
35             35                  1                                                            =   $25.00   |
-------------------------------------------------------------------------------------------------------------|
35             40                  1                                                            =   $112.50  |
-------------------------------------------------------------------------------------------------------------|
35             45                  1                                                            =   $200.00  |
-------------------------------------------------------------------------------------------------------------|
35             50                  1                                                            =   $287.50  |
-------------------------------------------------------------------------------------------------------------|
35             60                  1                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
35             30                  1                                                            =   $0.00  (it actually goes into the negative numbers at -62.50.)  I guess we owe this man money.
-------------------------------------------------------------------------------------------------------------|
35             80                  1                                                            =   $962.50  |
-------------------------------------------------------------------------------------------------------------|
35             70                  1                                                            =   $787.50  |
-------------------------------------------------------------------------------------------------------------|
35             38                  2                                                            =   $75.00   |
-------------------------------------------------------------------------------------------------------------|
35             35                  2                                                            =   $75.00   |
-------------------------------------------------------------------------------------------------------------|
35             40                  2                                                            =   $162.50  |
-------------------------------------------------------------------------------------------------------------|
35             50                  2                                                            =   $337.50  |
-------------------------------------------------------------------------------------------------------------|
35             60                  2                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
35             70                  2                                                            =   $787.50  |
-------------------------------------------------------------------------------------------------------------|
35             80                  2                                                            =   $962.50  |
-------------------------------------------------------------------------------------------------------------|
35             40                  3                                                            =   $162.50  |    
-------------------------------------------------------------------------------------------------------------|
35             50                  3                                                            =   $337.50  |
-------------------------------------------------------------------------------------------------------------|
35             60                  3                                                            =   $612.50  |
-------------------------------------------------------------------------------------------------------------|
35             70                  3                                                            =   $787.50  |
-------------------------------------------------------------------------------------------------------------|
35             80                  3                                                            =   $962.50  |       
-------------------------------------------------------------------------------------------------------------|
35             40                  4                                                            =   $212.50  |
-------------------------------------------------------------------------------------------------------------|
35             50                  4                                                            =   $387.50  |
-------------------------------------------------------------------------------------------------------------|
35             60                  4                                                            =   $712.50  |
-------------------------------------------------------------------------------------------------------------|
35             70                  4                                                            =   $887.50  |
-------------------------------------------------------------------------------------------------------------|
35             80                  4                                                            =   $1062.50 |
-------------------------------------------------------------------------------------------------------------|
35             55                  1                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             65                  1                                                            =   $700.00  |
-------------------------------------------------------------------------------------------------------------|
35             75                  1                                                            =   $875.00  |
-------------------------------------------------------------------------------------------------------------|
35             85                  1                                                            =   $1050.00 |
-------------------------------------------------------------------------------------------------------------|
35             55                  2                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             65                  2                                                            =   $700.00  |   
-------------------------------------------------------------------------------------------------------------|
35             45                  2                                                            =   $250.00  |
-------------------------------------------------------------------------------------------------------------|
35             75                  2                                                            =   $875.00  |
-------------------------------------------------------------------------------------------------------------|
35             45                  3                                                            =   $250.00  |
-------------------------------------------------------------------------------------------------------------|
35             55                  3                                                            =   $525.00  |
-------------------------------------------------------------------------------------------------------------|
35             65                  3                                                            =   $700.00  |
-------------------------------------------------------------------------------------------------------------|
35             75                  3                                                            =   $875.00  |
-------------------------------------------------------------------------------------------------------------|
35             75                  4                                                            =   $975.00  |
-------------------------------------------------------------------------------------------------------------|
35             65                  4                                                            =   $800.00  |
-------------------------------------------------------------------------------------------------------------|
35             55                  4                                                            =   $475.00  |
-------------------------------------------------------------------------------------------------------------|
35             45                  4                                                            =   $300.00  |
-------------------------------------------------------------------------------------------------------------|
--------------------------------------------------------------------------------------------------------------

Time: 1244 - 2022- 03- 25  through  1541 - 2022-03-25 this desk check took forever to make :O    Phew

Program will end here at 2022 - 03 - 25 the time is 1545.   all DONE!




End time: 1545 - 2022 03 25