This my solution for Lab 5 Unit 2 in the 2022 C# .NET After-Hours Boot Camp at Grand Circus.

# Lab 5: Factorial Calculator

### Objectives: 
User Input, Calculations

### Task: 
Calculate the factorial of a number.

### What will the application do?
- The application prompts the user to enter an integer from 1 to 10.
- The application displays the factorial of the number entered by the user.
- The application prompts the user to continue.

### Build Specifications:
- Use a for loop to calculate the factorial.
- Assume that the user will enter valid data. 
- Use the long type to store the factorial. 
- The application should continue only if the user agrees to.

### Hints:
A factorial is a number multiplied by each of the numbers before it. Factorials are denoted by the exclamation point (n!). Ex:
- 1! = 1				which equals 1
- 2! = 1 x 2			which equals 2
- 3! = 1 x 2 x 3 			which equals 6
- 4! = 1 x 2 x 3 x 4		which equals 24

### Extra Challenges:
- Test the application and find the integer for the highest factorial that can be accurately calculated by this application, then modify the prompt so that it prompts the user for a number “from 1 to {the highest integer that returns accurate factorial calculation}”.
- Use Recursion to implement the factorial. 

### Tests:
- Test 1

### Console Preview:
```
Welcome to the Factorial Calculator!

Enter an integer that’s greater than 0 but less than 10: {user input here, for example: 3}
The factorial of 3 is 6.

Continue? (y/n): {user input here, for example: Y}

Enter an integer that’s greater than 0 but less than 10: {user input here, for example: 9}
The factorial of 9 is 362880.
```
