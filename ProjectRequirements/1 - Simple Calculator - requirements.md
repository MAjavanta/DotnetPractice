

                           Simple calculator  
                 **Ultimate C\# Masterclass Assignment**

##                  **Overview **                                                                                                                                 

| This application is a simple calculator. The user will input two numbers and the operation they want to perform (addition, subtraction, multiplication), and the program shall print the operation and the result. |  Console App |
| :---- | :---- |

##               **Main application workflow**    

| When the application starts, it shall print: |
| :---- |
| Hello\! Input the first number: |
| Then, the user will input a number. For now, we **don't handle invalid input**. If the user inputs something that is not a number, we are OK with the fact that the application will crash. |
| Then, the program will print: |
| Input the second number: |
| And again, the user will enter the number. |
| Next, the program will ask: |
| What do you want to do with those numbers? \[A\]dd \[S\]ubtract \[M\]ultiply |
| The app should handle the input according to the “**Selecting an option by the user**” table. |
| Next, the application should print “Press any key to close” and close after the key press. |

 

##                 **Selecting an option by the user**

| Scenario | User action | Result |
| :---- | :---- | :---- |
| Addition | User enters ‘A’ or ‘a’ into the console. | The application prints something like **5 \+ 10 \= 15** to the console, assuming the first number was 5 and the second 10\. |
| Subtraction | User enters ‘S’ or ‘s’ into the console. | The application prints something like **5 \- 10 \= \-5** to the console, assuming the first number was 5 and the second 10\. |
| Multiplication | User enters ‘M’ or ‘m’ into the console. | The application prints something like **5 \* 10 \= 50** to the console, assuming the first number was 5 and the second 10\. |
| Incorrect or empty input | User does not select any option (empty choice), or the selected option is not valid. | “Invalid option” is printed to the console.  |

