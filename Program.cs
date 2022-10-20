/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ 
OCT 18, 2022 4:05 PM
THIS PROGRAM WILL ASK THE USER FOR A FIRST NUMBER 
AND IF IT IS A VAILD (A NUMBER). THEN IT WILL MOVE 
ONTO THE SECOUND NUMBER AND CHECK IF THAT TOO IS 
VAILD. IF THE USER HAPPENS TO TYPE IN ANY OTHER 
CHARACTER THAT ISNT A NUMBER THEN IT WILL ASK THEM 
TO TRY AGAIN AND TYPE IN A VAILD NUMBER, OTHERWISE 
IT WILL COUNTINE TO ASK THEM AND NOT MOVE ON. AFTER
COMPARING THE 2 NUMBERS AND DISPLAYING IT ON THE 
TERMINAL THE PROGRAM WILL ASK THE USER IF THEY WANNA 
PLAY AGAIN. IF THEY ENTER ANY VARIATION OF 'YES' THE 
PROGRAM WILL RUN AGAIN. IF THE USER ENTERS 'NO' IN ANY 
VARATION THEN THE PROGRAM WILL END. IF THEY ENTER ANYTHING 
ELSE IT WONT BE VAILD AND THEY WILL BE ASKED AGAIN UNTILL
THEY TYPE YES OR NO.

PEER REVIEW: NAME -- REVIEW

*/
Console.Clear();
bool playAgain = true;
while(playAgain){
    Console.WriteLine("▰▱▰▱▰▱▰▱▰▱▰▱▰▱ LETS COMPARE TWO NUMBERS ▰▱▰▱▰▱▰▱▰▱▰▱▰▱");

    string userInput;
    string userInput2;

    bool convetOne = true;
    bool isNumber; 
    long num1 = 0;
            
    while (convetOne){
        Console.WriteLine("ENTER A 1ST WHOLE NUMBER: ");
        userInput = Console.ReadLine();

        isNumber = Int64.TryParse(userInput, out num1);

        if(isNumber == true) {
            convetOne = false;
            Console.WriteLine("YOU ENTERED A NUMBER ");
            Console.WriteLine( " " );
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("INVAILD ENTRY, TRY AGAIN ");
            Console.WriteLine( " " );
        }        
    }

    bool convertTwo = true;
    bool isNumber2; 
    long num2 = 0;
            
    while (convertTwo){
        Console.WriteLine("ENTER A 2ND WHOLE NUMBER: ");
        userInput2 = Console.ReadLine();

        isNumber2 = Int64.TryParse(userInput2, out num2);

        if(isNumber2 == true) {
            convertTwo = false;
            Console.WriteLine("YOU ENTERED A NUMBER ");
            Console.WriteLine( " " );
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("INVAILD ENTRY, TRY AGAIN ");
           Console.WriteLine( " " );
        }
    }

    Console.WriteLine(" ");
    if ( num1 > num2 ) {
        Console.WriteLine( num1 + " IS GREATER THAN " + num2);
        Console.WriteLine( num1 + "       >         " + num2);
        Console.WriteLine( " " );
        Console.WriteLine( num2 + " IS lESS THAN " + num1);
        Console.WriteLine( num2 + "      <       " + num1);
    } if ( num1 < num2 ) {
        Console.WriteLine( num1 + " IS LESS THAN " + num2);
        Console.WriteLine( num1 + "     <        " + num2 );
        Console.WriteLine( " " );
        Console.WriteLine( num2 + " IS GREATER THAN " + num1);
        Console.WriteLine( num2 + "      >      " + num1);
    } if ( num1 == num2 ) {
        Console.WriteLine( num1 + " IS EQUAL TO " + num2);
        Console.WriteLine( num1 + "       =      " + num2);
    }


    bool converted = true;
    while (converted){
        Console.WriteLine("");
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO?");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else {
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
            }
        } 
    }
