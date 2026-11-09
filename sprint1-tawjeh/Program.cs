namespace sprint1_tawjeh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 
            #region task1
            {
                // 1. Print Hello and Name
                {
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hello");
                    Console.WriteLine(name);
                }


                // 2. Sum of Two Numbers
                {
                    Console.WriteLine("Enter first number:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(num1 + num2);
                }


                // 3. Divide Two Numbers
                {
                    Console.WriteLine("Enter first number:");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(num1 / num2);
                }

                // 5. Swap Two Numbers
                {
                    Console.WriteLine("Enter first number:");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int b = int.Parse(Console.ReadLine());

                    int temp = a;
                    a = b;
                    b = temp;

                    Console.WriteLine("After swapping:");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }


                // 6. Multiply Three Numbers
                {
                    Console.WriteLine("Enter first number:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter third number:");
                    int num3 = int.Parse(Console.ReadLine());

                    Console.WriteLine(num1 * num2 * num3);
                }


                // 7. Arithmetic Operations
                {
                    Console.WriteLine("Enter first number:");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Addition = " + (n1 + n2));
                    Console.WriteLine("Subtraction = " + (n1 - n2));
                    Console.WriteLine("Multiplication = " + (n1 * n2));
                    Console.WriteLine("Division = " + (n1 / n2));
                    Console.WriteLine("Remainder = " + (n1 % n2));
                }


                // 8. Multiplication Table
                {
                    Console.WriteLine("Enter a number:");
                    int number = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine(number + " * " + i + " = " + (number * i));
                    }
                }


                // 9. Average of Four Numbers
                {
                    Console.WriteLine("Enter first number:");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter third number:");
                    double n3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter fourth number:");
                    double n4 = double.Parse(Console.ReadLine());

                    double average = (n1 + n2 + n3 + n4) / 4;

                    Console.WriteLine("Average = " + average);
                }


                // 10. Specified Formula with Three Numbers
                {
                    Console.WriteLine("Enter x:");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter y:");
                    int y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter z:");
                    int z = int.Parse(Console.ReadLine());

                    Console.WriteLine("(x + y) * z = " + ((x + y) * z));
                    Console.WriteLine("x * y + y * z = " + (x * y + y * z));
                }


                // 11. Print Age Message
                {
                    Console.WriteLine("Enter your age:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Your age is " + age);
                }


                // 12. Repeat Number in Rows
                {
                    Console.WriteLine("Enter a number:");
                    int digit = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(digit + " " + digit + " " + digit + " " + digit);
                        Console.WriteLine("" + digit + digit + digit + digit);
                    }
                }


                // 13. Rectangle Pattern with Number
                {
                    Console.WriteLine("Enter a digit:");
                    int digit = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(digit);
                        }

                        Console.WriteLine();
                    }
                }


                // 14. Celsius to Kelvin and Fahrenheit
                {
                    Console.WriteLine("Enter Celsius temperature:");
                    double celsius = double.Parse(Console.ReadLine());

                    double kelvin = celsius + 273.15;
                    double fahrenheit = (celsius * 9 / 5) + 32;

                    Console.WriteLine("Kelvin = " + kelvin);
                    Console.WriteLine("Fahrenheit = " + fahrenheit);
                }


                // 15. Remove Character by Index
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    Console.WriteLine("Enter index:");
                    int index = int.Parse(Console.ReadLine());

                    string result = str.Remove(index, 1);

                    Console.WriteLine(result);
                }


                // 16. Swap First and Last Characters
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    string result = str;

                    if (str.Length > 1)
                    {
                        result = str[str.Length - 1] +
                                 str.Substring(1, str.Length - 2) +
                                 str[0];
                    }

                    Console.WriteLine(result);
                }


                // 17. Add First Character to Front and Back
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    string result = str[0] + str + str[0];

                    Console.WriteLine(result);
                }


                // 18. Check Positive and Negative Pair
                {
                    Console.WriteLine("Enter first number:");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int b = int.Parse(Console.ReadLine());

                    bool result = (a < 0 && b > 0) || (a > 0 && b < 0);

                    Console.WriteLine(result);
                }


                // 19. Sum or Triple Sum of Integers
                {
                    Console.WriteLine("Enter first number:");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int y = int.Parse(Console.ReadLine());

                    int sum = x + y;

                    if (x == y)
                    {
                        sum = sum * 3;
                    }

                    Console.WriteLine(sum);
                }


                // 20. Absolute Difference or Double It
                {
                    Console.WriteLine("Enter first number:");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int n2 = int.Parse(Console.ReadLine());

                    int difference = Math.Abs(n1 - n2);

                    if (n1 > n2)
                    {
                        difference *= 2;
                    }

                    Console.WriteLine(difference);
                }


                // 21. Check for 20 or Sum Equals 20
                {
                    Console.WriteLine("Enter first number:");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int n2 = int.Parse(Console.ReadLine());

                    bool result = n1 == 20 || n2 == 20 || n1 + n2 == 20;

                    Console.WriteLine(result);
                }


                // 22. Check Within 20 of 100 or 200
                {
                    Console.WriteLine("Enter a number:");
                    int number = int.Parse(Console.ReadLine());

                    bool result = Math.Abs(number - 100) <= 20 ||
                                  Math.Abs(number - 200) <= 20;

                    Console.WriteLine(result);
                }


                // 23. Convert String to Lowercase
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    Console.WriteLine(str.ToLower());
                }


                // 24. Find Longest Word in String
                {
                    Console.WriteLine("Enter a sentence:");
                    string sentence = Console.ReadLine();

                    string[] words = sentence.Split(' ');

                    string longest = words[0];

                    foreach (string word in words)
                    {
                        if (word.Length > longest.Length)
                        {
                            longest = word;
                        }
                    }

                    Console.WriteLine(longest);
                }


                // 25. Print Odd Numbers 1 to 99
                {
                    for (int i = 1; i <= 99; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }


                // 26. Sum of First 500 Primes
                {
                    int count = 0;
                    int number = 2;
                    long sum = 0;

                    while (count < 500)
                    {
                        bool isPrime = true;

                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            sum += number;
                            count++;
                        }

                        number++;
                    }

                    Console.WriteLine(sum);
                }


                // 27. Sum of Digits in Integer
                {
                    Console.WriteLine("Enter an integer:");
                    int num = Math.Abs(int.Parse(Console.ReadLine()));

                    int sum = 0;

                    while (num > 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }

                    Console.WriteLine(sum);
                }


                // 28. Reverse Words in Sentence
                {
                    Console.WriteLine("Enter a sentence:");
                    string sentence = Console.ReadLine();

                    string[] words = sentence.Split(
                        ' ',
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    Array.Reverse(words);

                    Console.WriteLine(string.Join(" ", words));
                }


                // 29. File Size in Bytes
                {
                    Console.WriteLine("Enter file path:");
                    string path = Console.ReadLine();

                    FileInfo file = new FileInfo(path);

                    Console.WriteLine(file.Length);
                }


                // 30. Hexadecimal to Decimal
                {
                    Console.WriteLine("Enter hexadecimal number:");
                    string hex = Console.ReadLine();

                    int decimalNumber = Convert.ToInt32(hex, 16);

                    Console.WriteLine(decimalNumber);
                }


                // 31. Multiply Two Arrays
                {
                    Console.WriteLine("Enter array size:");
                    int size = int.Parse(Console.ReadLine());

                    int[] arr1 = new int[size];
                    int[] arr2 = new int[size];

                    Console.WriteLine("Enter first array elements:");

                    for (int i = 0; i < size; i++)
                    {
                        arr1[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Enter second array elements:");

                    for (int i = 0; i < size; i++)
                    {
                        arr2[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine(arr1[i] * arr2[i]);
                    }
                }


                // 32. Four Copies of Last Four Characters
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    if (str.Length < 4)
                    {
                        Console.WriteLine(str);
                    }
                    else
                    {
                        string lastFour = str.Substring(str.Length - 4);

                        Console.WriteLine(lastFour + lastFour + lastFour + lastFour);
                    }
                }


                // 33. Check Multiple of 3 or 7
                {
                    Console.WriteLine("Enter a positive number:");
                    int number = int.Parse(Console.ReadLine());

                    bool result = number % 3 == 0 || number % 7 == 0;

                    Console.WriteLine(result);
                }


                // 34. Check String Starts with Word
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    Console.WriteLine("Enter a word:");
                    string word = Console.ReadLine();

                    bool result = str.StartsWith(word);

                    Console.WriteLine(result);
                }


                // 35. Check Numbers Less than 100 and Greater than 200
                {
                    Console.WriteLine("Enter first number:");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int b = int.Parse(Console.ReadLine());

                    bool result = (a < 100 && b > 200) ||
                                  (b < 100 && a > 200);

                    Console.WriteLine(result);
                }


                // 36. Check Integer in Range -10 to 10
                {
                    Console.WriteLine("Enter first number:");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int b = int.Parse(Console.ReadLine());

                    bool result = (a >= -10 && a <= 10) ||
                                  (b >= -10 && b <= 10);

                    Console.WriteLine(result);
                }


                // 37. Remove 'HP' from String
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    if (str.Length >= 3 && str.Substring(1, 2) == "HP")
                    {
                        str = str.Remove(1, 2);
                    }

                    Console.WriteLine(str);
                }


                // 38. Extract 'PH' from String
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    string result = "";

                    if (str.Length >= 2 && str.Substring(0, 2) == "PH")
                    {
                        result = "PH";
                    }

                    Console.WriteLine(result);
                }


                // 39. Largest and Lowest of Three Integers
                {
                    Console.WriteLine("Enter first number:");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter third number:");
                    int n3 = int.Parse(Console.ReadLine());

                    int largest = Math.Max(n1, Math.Max(n2, n3));
                    int lowest = Math.Min(n1, Math.Min(n2, n3));

                    Console.WriteLine("Largest = " + largest);
                    Console.WriteLine("Lowest = " + lowest);
                }


                // 40. Nearest to 20 or Return 0
                {
                    Console.WriteLine("Enter first number:");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int y = int.Parse(Console.ReadLine());

                    int result = 0;

                    if (x != y)
                    {
                        if (Math.Abs(x - 20) < Math.Abs(y - 20))
                        {
                            result = x;
                        }
                        else
                        {
                            result = y;
                        }
                    }

                    Console.WriteLine(result);
                }


                // 41. Check 'w' Appears 1-3 Times
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    int count = 0;

                    foreach (char c in str)
                    {
                        if (c == 'w')
                        {
                            count++;
                        }
                    }

                    bool result = count >= 1 && count <= 3;

                    Console.WriteLine(result);
                }


                // 42. First 4 Chars Lowercase, Rest Uppercase
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    string result;

                    if (str.Length < 4)
                    {
                        result = str.ToUpper();
                    }
                    else
                    {
                        result = str.Substring(0, 4).ToLower() +
                                 str.Substring(4).ToUpper();
                    }

                    Console.WriteLine(result);
                }


                // 43. Check String Starts with 'www'
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    bool result = str.StartsWith("www");

                    Console.WriteLine(result);
                }


                // 44. Every Other Character in String
                {
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    string result = "";

                    for (int i = 0; i < str.Length; i += 2)
                    {
                        result += str[i];
                    }

                    Console.WriteLine(result);

                }
            }
            #endregion

            //task2 
            #region task2
            {
                // Question 1

                char letter1 = char.Parse(Console.ReadLine());
                char letter2 = char.Parse(Console.ReadLine());
                char letter3 = char.Parse(Console.ReadLine());

                Console.WriteLine(letter3);
                Console.WriteLine(letter2);
                Console.WriteLine(letter1);


                // Question 2

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());

                for (int i = width; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number);
                    }

                    Console.WriteLine();
                }


                // Question 3

                string correctID = "admin";
                string correctPassword = "1234";

                int attempts = 0;

                while (attempts < 3)
                {
                    Console.Write("Enter ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    if (id == correctID && password == correctPassword)
                    {
                        Console.WriteLine("Login Successful");
                        break;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Invalid ID or Password");
                    }
                }

                if (attempts == 3)
                {
                    Console.WriteLine("Access Denied");
                }


                // Question 4
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Enter operator: ");
                char op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;

                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;

                    case '*':
                    case 'x':
                    case 'X':
                        Console.WriteLine(num1 * num2);
                        break;

                    case '/':
                        if (num2 != 0)
                            Console.WriteLine(num1 / num2);
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }


                // Question 5

                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());

                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * radius * radius;

                Console.WriteLine("Perimeter = " + perimeter);
                Console.WriteLine("Area = " + area);


                // Question 6

                for (int y = -5; y <= 5; y++)
                {
                    int x = y * y + 2 * y + 1;

                    Console.WriteLine("y = " + y + " , x = " + x);
                }


                // Question 7

                Console.Write("Enter distance in meters: ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Enter hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter minutes: ");
                int minutes = int.Parse(Console.ReadLine());

                Console.Write("Enter seconds: ");
                int seconds = int.Parse(Console.ReadLine());

                double totalSeconds = hours * 3600 + minutes * 60 + seconds;

                if (totalSeconds > 0)
                {
                    double speedMS = distance / totalSeconds;
                    double speedKMH = speedMS * 3.6;
                    double speedMPH = speedMS * 2.23694;

                    Console.WriteLine("Speed in m/s = " + speedMS);
                    Console.WriteLine("Speed in km/h = " + speedKMH);
                    Console.WriteLine("Speed in mph = " + speedMPH);
                }
                else
                {
                    Console.WriteLine("Time must be greater than zero");
                }


                // Question 8

                Console.Write("Enter sphere radius: ");
                double sphereRadius = double.Parse(Console.ReadLine());

                double surfaceArea = 4 * Math.PI * sphereRadius * sphereRadius;

                double volume = (4.0 / 3.0) * Math.PI * sphereRadius * sphereRadius * sphereRadius;

                Console.WriteLine("Surface Area = " + surfaceArea);
                Console.WriteLine("Volume = " + volume);


                // Question 9

                Console.Write("Enter a character: ");
                char ch = char.Parse(Console.ReadLine());

                if ("aeiouAEIOU".Contains(ch))
                {
                    Console.WriteLine("Vowel");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine("Digit");
                }
                else
                {
                    Console.WriteLine("Other Symbol");
                }


                // Question 10

                Console.Write("Enter first number: ");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                bool result = firstNumber % 2 == secondNumber % 2;

                Console.WriteLine(result);


                // Question 11

                Console.Write("Enter a decimal number: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                string binary = Convert.ToString(decimalNumber, 2);

                Console.WriteLine("Binary = " + binary);
            }
            #endregion
            //task3
            #region task3
            {
                // 1. Check whether two integers are equal
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (num1 == num2)
                    Console.WriteLine("Equal");
                else
                    Console.WriteLine("Not Equal");


                // 2. Even or Odd
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");


                // 3. Positive or Negative
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                    Console.WriteLine("Positive");
                else if (num < 0)
                    Console.WriteLine("Negative");
                else
                    Console.WriteLine("Zero");


                // 4. Leap Year
                int year = int.Parse(Console.ReadLine());

                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    Console.WriteLine("Leap Year");
                else
                    Console.WriteLine("Not Leap Year");


                // 5. Voting Eligibility
                int age = int.Parse(Console.ReadLine());

                if (age >= 18)
                    Console.WriteLine("Eligible to Vote");
                else
                    Console.WriteLine("Not Eligible to Vote");


                // 6. Signum Function
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                    Console.WriteLine(1);
                else if (num == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(-1);


                // 7. Height Classification
                double height = double.Parse(Console.ReadLine());

                if (height < 150)
                    Console.WriteLine("Short");
                else if (height < 170)
                    Console.WriteLine("Average");
                else
                    Console.WriteLine("Tall");


                // 8. Largest of Three Numbers
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a >= b && a >= c)
                    Console.WriteLine(a);
                else if (b >= a && b >= c)
                    Console.WriteLine(b);
                else
                    Console.WriteLine(c);


                // 9. Identify XY Coordinate Quadrant
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                    Console.WriteLine("First Quadrant");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Second Quadrant");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Third Quadrant");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Fourth Quadrant");
                else if (x == 0 && y == 0)
                    Console.WriteLine("Origin");
                else
                    Console.WriteLine("On Axis");


                // 10. Professional Course Admission
                int math = int.Parse(Console.ReadLine());
                int physics = int.Parse(Console.ReadLine());
                int chemistry = int.Parse(Console.ReadLine());

                int total = math + physics + chemistry;

                if (math >= 65 && physics >= 55 &&
                    chemistry >= 50 && total >= 180)
                    Console.WriteLine("Eligible");
                else
                    Console.WriteLine("Not Eligible");


                // 11. Quadratic Equation Roots
                double qa = double.Parse(Console.ReadLine());
                double qb = double.Parse(Console.ReadLine());
                double qc = double.Parse(Console.ReadLine());

                if (qa == 0)
                {
                    Console.WriteLine("Not a Quadratic Equation");
                }
                else
                {
                    double d = qb * qb - 4 * qa * qc;

                    if (d > 0)
                    {
                        double root1 = (-qb + Math.Sqrt(d)) / (2 * qa);
                        double root2 = (-qb - Math.Sqrt(d)) / (2 * qa);

                        Console.WriteLine(root1);
                        Console.WriteLine(root2);
                    }
                    else if (d == 0)
                    {
                        double root = -qb / (2 * qa);
                        Console.WriteLine(root);
                    }
                    else
                    {
                        double real = -qb / (2 * qa);
                        double imaginary = Math.Sqrt(-d) / (2 * qa);

                        Console.WriteLine($"{real} + {imaginary}i");
                        Console.WriteLine($"{real} - {imaginary}i");
                    }
                }


                // 12. Student Marks, Total, Percentage and Division
                int rollNo = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                double m1 = double.Parse(Console.ReadLine());
                double m2 = double.Parse(Console.ReadLine());
                double m3 = double.Parse(Console.ReadLine());

                double studentTotal = m1 + m2 + m3;
                double percentage = studentTotal / 300 * 100;

                Console.WriteLine("Roll No: " + rollNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Total: " + studentTotal);
                Console.WriteLine("Percentage: " + percentage);

                if (percentage >= 60)
                    Console.WriteLine("First Division");
                else if (percentage >= 50)
                    Console.WriteLine("Second Division");
                else if (percentage >= 40)
                    Console.WriteLine("Third Division");
                else
                    Console.WriteLine("Fail");


                // 13. Celsius Temperature and Weather Description
                double temp = double.Parse(Console.ReadLine());

                if (temp < 0)
                    Console.WriteLine("Freezing Weather");
                else if (temp < 10)
                    Console.WriteLine("Very Cold Weather");
                else if (temp < 20)
                    Console.WriteLine("Cold Weather");
                else if (temp < 30)
                    Console.WriteLine("Normal Weather");
                else if (temp < 40)
                    Console.WriteLine("Hot Weather");
                else
                    Console.WriteLine("Very Hot Weather");


                // 14. Triangle Classification
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());

                if (side1 <= 0 || side2 <= 0 || side3 <= 0 ||
                    side1 + side2 <= side3 ||
                    side1 + side3 <= side2 ||
                    side2 + side3 <= side1)
                {
                    Console.WriteLine("Invalid Triangle");
                }
                else if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }


                // 15. Valid Triangle Using Three Angles
                double angle1 = double.Parse(Console.ReadLine());
                double angle2 = double.Parse(Console.ReadLine());
                double angle3 = double.Parse(Console.ReadLine());

                if (angle1 > 0 && angle2 > 0 && angle3 > 0 &&
                    angle1 + angle2 + angle3 == 180)
                    Console.WriteLine("Valid Triangle");
                else
                    Console.WriteLine("Invalid Triangle");


                // 16. Alphabet, Digit or Special Character
                char ch = char.Parse(Console.ReadLine());

                if (char.IsLetter(ch))
                    Console.WriteLine("Alphabet");
                else if (char.IsDigit(ch))
                    Console.WriteLine("Digit");
                else
                    Console.WriteLine("Special Character");


                // 17. Vowel or Consonant
                ch = char.Parse(Console.ReadLine());

                if (!char.IsLetter(ch))
                {
                    Console.WriteLine("Not an Alphabet");
                }
                else if (ch == 'a' || ch == 'e' || ch == 'i' ||
                         ch == 'o' || ch == 'u' ||
                         ch == 'A' || ch == 'E' || ch == 'I' ||
                         ch == 'O' || ch == 'U')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }


                // 18. Profit or Loss
                double costPrice = double.Parse(Console.ReadLine());
                double sellingPrice = double.Parse(Console.ReadLine());

                if (sellingPrice > costPrice)
                {
                    double profit = sellingPrice - costPrice;
                    Console.WriteLine("Profit = " + profit);
                }
                else if (sellingPrice < costPrice)
                {
                    double loss = costPrice - sellingPrice;
                    Console.WriteLine("Loss = " + loss);
                }
                else
                {
                    Console.WriteLine("No Profit No Loss");
                }


                // 19. Electricity Bill Calculation
                int units = int.Parse(Console.ReadLine());

                double bill;

                if (units <= 50)
                {
                    bill = units * 0.50;
                }
                else if (units <= 150)
                {
                    bill = 50 * 0.50 + (units - 50) * 0.75;
                }
                else if (units <= 250)
                {
                    bill = 50 * 0.50 + 100 * 0.75 +
                           (units - 150) * 1.20;
                }
                else
                {
                    bill = 50 * 0.50 + 100 * 0.75 +
                           100 * 1.20 + (units - 250) * 1.50;
                }

                if (bill > 400)
                    bill += bill * 0.15;

                if (bill < 100)
                    bill = 100;

                Console.WriteLine("Electricity Bill = Rs. " + bill);


                // 20. Grade Description
                char grade = char.Parse(Console.ReadLine());

                switch (char.ToUpper(grade))
                {
                    case 'E':
                        Console.WriteLine("Excellent");
                        break;

                    case 'V':
                        Console.WriteLine("Very Good");
                        break;

                    case 'G':
                        Console.WriteLine("Good");
                        break;

                    case 'A':
                        Console.WriteLine("Average");
                        break;

                    case 'F':
                        Console.WriteLine("Fail");
                        break;

                    default:
                        Console.WriteLine("Invalid Grade");
                        break;
                }


                // 21. Day Number to Weekday Name
                int day = int.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid Day Number");
                        break;
                }


                // 22. Single Digit to Word
                int digit = int.Parse(Console.ReadLine());

                switch (digit)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:
                        Console.WriteLine("Not a Single Digit");
                        break;
                }


                // 23. Month Number to Month Name
                int month = int.Parse(Console.ReadLine());

                switch (month)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("Invalid Month");
                        break;
                }


                // 24. Number of Days in a Month
                month = int.Parse(Console.ReadLine());
                year = int.Parse(Console.ReadLine());

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("31 Days");
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("30 Days");
                        break;

                    case 2:
                        if (year % 400 == 0 ||
                            (year % 4 == 0 && year % 100 != 0))
                            Console.WriteLine("29 Days");
                        else
                            Console.WriteLine("28 Days");
                        break;

                    default:
                        Console.WriteLine("Invalid Month");
                        break;
                }


                // 25. Menu-Driven Calculator for Areas of Geometric Shapes
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Triangle");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double radius = double.Parse(Console.ReadLine());
                        double circleArea = Math.PI * radius * radius;
                        Console.WriteLine("Area = " + circleArea);
                        break;

                    case 2:
                        double length = double.Parse(Console.ReadLine());
                        double width = double.Parse(Console.ReadLine());
                        double rectangleArea = length * width;
                        Console.WriteLine("Area = " + rectangleArea);
                        break;

                    case 3:
                        double side = double.Parse(Console.ReadLine());
                        double squareArea = side * side;
                        Console.WriteLine("Area = " + squareArea);
                        break;

                    case 4:
                        double baseLength = double.Parse(Console.ReadLine());
                        double triangleHeight = double.Parse(Console.ReadLine());
                        double triangleArea = 0.5 * baseLength * triangleHeight;
                        Console.WriteLine("Area = " + triangleArea);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }


                // 26. Menu-Driven Simple Arithmetic Calculator
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");

                choice = int.Parse(Console.ReadLine());

                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result = " + (number1 + number2));
                        break;

                    case 2:
                        Console.WriteLine("Result = " + (number1 - number2));
                        break;

                    case 3:
                        Console.WriteLine("Result = " + (number1 * number2));
                        break;

                    case 4:
                        if (number2 != 0)
                            Console.WriteLine("Result = " + (number1 / number2));
                        else
                            Console.WriteLine("Cannot Divide by Zero");
                        break;

                    case 5:
                        if (number2 != 0)
                            Console.WriteLine("Result = " + (number1 % number2));
                        else
                            Console.WriteLine("Cannot Calculate Modulus by Zero");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            #endregion
            //task4
            #region task4
            // 1. Display the first 10 natural numbers.
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }


            // 2. Find the sum of the first 10 natural numbers.
            {
                int sum = 0;

                for (int i = 1; i <= 10; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Sum = " + sum);
            }


            // 3. Display the first n natural numbers and their sum.
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }

                Console.WriteLine("\nSum = " + sum);
            }


            // 4. Read 10 numbers and calculate their sum and average.
            {
                double sum = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Enter number " + i + ": ");
                    double number = double.Parse(Console.ReadLine());

                    sum += number;
                }

                double average = sum / 10;

                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = " + average);
            }


            // 5. Display the cubes of integers from 1 through a supplied limit.
            {
                Console.Write("Enter the limit: ");
                int limit = int.Parse(Console.ReadLine());

                for (int i = 1; i <= limit; i++)
                {
                    Console.WriteLine(i + " cube = " + (i * i * i));
                }
            }


            // 6. Display the multiplication table of a supplied integer.
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + (number * i));
                }
            }


            // 7. Display multiplication tables from 1 through n vertically.
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Multiplication table of " + i);

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + (i * j));
                    }

                    Console.WriteLine();
                }
            }


            // 8. Display the first n odd natural numbers and their sum.
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                int odd = 1;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(odd + " ");
                    sum += odd;
                    odd += 2;
                }

                Console.WriteLine("\nSum = " + sum);
            }


            // 9. Print a right-angle triangle made of asterisks.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }


            // 10. Print a right-angle triangle: 1, 12, 123, ...
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }

                    Console.WriteLine();
                }
            }


            // 11. Print a right-angle triangle: 1, 22, 333, ...
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }

                    Console.WriteLine();
                }
            }


            // 12. Print a right-angle triangle filled with consecutive increasing numbers.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                int number = 1;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number + " ");
                        number++;
                    }

                    Console.WriteLine();
                }
            }


            // 13. Print a number pyramid filled with consecutive increasing numbers.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                int number = 1;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write("  ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number + " ");
                        number++;
                    }

                    Console.WriteLine();
                }
            }


            // 14. Print a centered pyramid made of asterisks.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= (2 * i) - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }


            // 15. Calculate the factorial of a supplied number.
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("Factorial = " + factorial);
            }


            // 16. Display the first n even natural numbers and their sum.
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    int even = i * 2;

                    Console.Write(even + " ");
                    sum += even;
                }

                Console.WriteLine("\nSum = " + sum);
            }


            // 17. Print a number pyramid where each row repeats its row number.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine();
                }
            }


            // 18. Calculate the first n terms of the series:
            // 1 - x^2/2! + x^4/4! - ...
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter number of terms: ");
                int n = int.Parse(Console.ReadLine());

                double sum = 0;

                for (int i = 0; i < n; i++)
                {
                    double power = Math.Pow(x, 2 * i);

                    double factorial = 1;

                    for (int j = 1; j <= 2 * i; j++)
                    {
                        factorial *= j;
                    }

                    double term = power / factorial;

                    if (i % 2 == 0)
                    {
                        sum += term;
                    }
                    else
                    {
                        sum -= term;
                    }
                }

                Console.WriteLine("Sum = " + sum);
            }


            // 19. Display n terms of the harmonic series and calculate their sum.
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                double sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double term = 1.0 / i;

                    Console.Write("1/" + i);

                    if (i < n)
                    {
                        Console.Write(" + ");
                    }

                    sum += term;
                }

                Console.WriteLine("\nSum = " + sum);
            }


            // 20. Print an asterisk pyramid where each row contains an odd number of stars.
            {
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= (2 * i) - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            #endregion
            //task4
            #region task5
            // 1. Read a string and print it.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.WriteLine("String = " + text);
            }


            // 2. Find a string's length without using a library length function.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                int count = 0;

                foreach (char c in text)
                {
                    count++;
                }

                Console.WriteLine("Length = " + count);
            }


            // 3. Print the individual characters in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                foreach (char c in text)
                {
                    Console.WriteLine(c);
                }
            }


            // 4. Print the characters of a string in reverse order.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }

                Console.WriteLine();
            }


            // 5. Count the words in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                int count = 0;
                bool insideWord = false;

                foreach (char c in text)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        if (!insideWord)
                        {
                            count++;
                            insideWord = true;
                        }
                    }
                    else
                    {
                        insideWord = false;
                    }
                }

                Console.WriteLine("Number of words = " + count);
            }


            // 6. Compare two strings without string-library comparison functions.
            {
                Console.Write("Enter first string: ");
                string first = Console.ReadLine();

                Console.Write("Enter second string: ");
                string second = Console.ReadLine();

                bool equal = true;

                if (first.Length != second.Length)
                {
                    equal = false;
                }
                else
                {
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (first[i] != second[i])
                        {
                            equal = false;
                            break;
                        }
                    }
                }

                if (equal)
                {
                    Console.WriteLine("Strings are equal.");
                }
                else
                {
                    Console.WriteLine("Strings are not equal.");
                }
            }


            // 7. Count alphabetic characters, digits, and special characters.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                int letters = 0;
                int digits = 0;
                int special = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        letters++;
                    }
                    else if (char.IsDigit(c))
                    {
                        digits++;
                    }
                    else
                    {
                        special++;
                    }
                }

                Console.WriteLine("Alphabetic characters = " + letters);
                Console.WriteLine("Digits = " + digits);
                Console.WriteLine("Special characters = " + special);
            }


            // 8. Copy one string into another and report the number of copied characters.
            {
                Console.Write("Enter a string: ");
                string original = Console.ReadLine();

                char[] copiedCharacters = new char[original.Length];

                int count = 0;

                foreach (char c in original)
                {
                    copiedCharacters[count] = c;
                    count++;
                }

                string copied = new string(copiedCharacters);

                Console.WriteLine("Copied string = " + copied);
                Console.WriteLine("Number of copied characters = " + count);
            }


            // 9. Count vowels and consonants in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                int vowels = 0;
                int consonants = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char lower = char.ToLower(c);

                        if (lower == 'a' || lower == 'e' ||
                            lower == 'i' || lower == 'o' ||
                            lower == 'u')
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                }

                Console.WriteLine("Vowels = " + vowels);
                Console.WriteLine("Consonants = " + consonants);
            }


            // 10. Find the most frequently occurring character in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                if (text.Length == 0)
                {
                    Console.WriteLine("The string is empty.");
                }
                else
                {
                    char mostFrequent = text[0];
                    int maxCount = 0;

                    for (int i = 0; i < text.Length; i++)
                    {
                        int count = 0;

                        for (int j = 0; j < text.Length; j++)
                        {
                            if (text[i] == text[j])
                            {
                                count++;
                            }
                        }

                        if (count > maxCount)
                        {
                            maxCount = count;
                            mostFrequent = text[i];
                        }
                    }

                    Console.WriteLine("Most frequent character = " + mostFrequent);
                    Console.WriteLine("Frequency = " + maxCount);
                }
            }


            // 11. Sort the characters of a string in ascending order.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                char[] characters = text.ToCharArray();

                for (int i = 0; i < characters.Length - 1; i++)
                {
                    for (int j = 0; j < characters.Length - 1 - i; j++)
                    {
                        if (characters[j] > characters[j + 1])
                        {
                            char temp = characters[j];
                            characters[j] = characters[j + 1];
                            characters[j + 1] = temp;
                        }
                    }
                }

                string sorted = new string(characters);

                Console.WriteLine("Sorted string = " + sorted);
            }


            // 12. Read multiple strings and sort them using bubble sort.
            {
                Console.Write("Enter number of strings: ");
                int n = int.Parse(Console.ReadLine());

                string[] words = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter string " + (i + 1) + ": ");
                    words[i] = Console.ReadLine();
                }

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        int comparison = 0;

                        int minLength = Math.Min(words[j].Length, words[j + 1].Length);

                        for (int k = 0; k < minLength; k++)
                        {
                            if (words[j][k] > words[j + 1][k])
                            {
                                comparison = 1;
                                break;
                            }
                            else if (words[j][k] < words[j + 1][k])
                            {
                                comparison = -1;
                                break;
                            }
                        }

                        if (comparison == 0)
                        {
                            if (words[j].Length > words[j + 1].Length)
                            {
                                comparison = 1;
                            }
                            else if (words[j].Length < words[j + 1].Length)
                            {
                                comparison = -1;
                            }
                        }

                        if (comparison > 0)
                        {
                            string temp = words[j];
                            words[j] = words[j + 1];
                            words[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted strings:");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(words[i]);
                }
            }


            // 13. Extract a substring without using the library substring function.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.Write("Enter starting position: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter substring length: ");
                int subLength = int.Parse(Console.ReadLine());

                if (start >= 0 && subLength >= 0 &&
                    start + subLength <= text.Length)
                {
                    char[] resultCharacters = new char[subLength];

                    for (int i = 0; i < subLength; i++)
                    {
                        resultCharacters[i] = text[start + i];
                    }

                    string result = new string(resultCharacters);

                    Console.WriteLine("Substring = " + result);
                }
                else
                {
                    Console.WriteLine("Invalid starting position or length.");
                }
            }


            // 14. Determine whether a specified substring occurs in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.Write("Enter substring to search: ");
                string sub = Console.ReadLine();

                bool found = false;

                if (sub.Length == 0)
                {
                    found = true;
                }
                else
                {
                    for (int i = 0; i <= text.Length - sub.Length; i++)
                    {
                        bool match = true;

                        for (int j = 0; j < sub.Length; j++)
                        {
                            if (text[i + j] != sub[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            found = true;
                            break;
                        }
                    }
                }

                if (found)
                {
                    Console.WriteLine("Substring found.");
                }
                else
                {
                    Console.WriteLine("Substring not found.");
                }
            }


            // 15. Swap uppercase letters to lowercase and lowercase letters to uppercase.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                char[] characters = text.ToCharArray();

                for (int i = 0; i < characters.Length; i++)
                {
                    if (char.IsUpper(characters[i]))
                    {
                        characters[i] = char.ToLower(characters[i]);
                    }
                    else if (char.IsLower(characters[i]))
                    {
                        characters[i] = char.ToUpper(characters[i]);
                    }
                }

                string result = new string(characters);

                Console.WriteLine("Result = " + result);
            }


            // 16. Validate a username and password.
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                bool validUsername = username.Length >= 5;
                bool validPassword = password.Length >= 8;

                foreach (char c in username)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        validUsername = false;
                        break;
                    }
                }

                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                bool hasSpecial = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(c))
                    {
                        hasLower = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                    else
                    {
                        hasSpecial = true;
                    }
                }

                validPassword = validPassword &&
                                hasUpper && hasLower &&
                                hasDigit && hasSpecial;

                if (validUsername && validPassword)
                {
                    Console.WriteLine("Valid username and password.");
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                }
            }


            // 17. Find the position of a substring within a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.Write("Enter substring: ");
                string sub = Console.ReadLine();

                int position = -1;

                if (sub.Length == 0)
                {
                    position = 0;
                }
                else
                {
                    for (int i = 0; i <= text.Length - sub.Length; i++)
                    {
                        bool match = true;

                        for (int j = 0; j < sub.Length; j++)
                        {
                            if (text[i + j] != sub[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            position = i;
                            break;
                        }
                    }
                }

                if (position != -1)
                {
                    Console.WriteLine("Position = " + position);
                }
                else
                {
                    Console.WriteLine("Substring not found.");
                }
            }


            // 18. Determine whether a character is alphabetic and, if so, whether it is uppercase or lowercase.
            {
                Console.Write("Enter a character: ");
                char ch = char.Parse(Console.ReadLine());

                if (char.IsLetter(ch))
                {
                    Console.WriteLine("It is an alphabetic character.");

                    if (char.IsUpper(ch))
                    {
                        Console.WriteLine("It is uppercase.");
                    }
                    else
                    {
                        Console.WriteLine("It is lowercase.");
                    }
                }
                else
                {
                    Console.WriteLine("It is not an alphabetic character.");
                }
            }


            // 19. Count how many times a substring occurs in a string.
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.Write("Enter substring: ");
                string sub = Console.ReadLine();

                int count = 0;

                if (sub.Length > 0)
                {
                    for (int i = 0; i <= text.Length - sub.Length; i++)
                    {
                        bool match = true;

                        for (int j = 0; j < sub.Length; j++)
                        {
                            if (text[i + j] != sub[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Occurrences = " + count);
            }


            // 20. Insert a substring before the first occurrence of another string.
            {
                Console.Write("Enter the original string: ");
                string text = Console.ReadLine();

                Console.Write("Enter the substring to search for: ");
                string search = Console.ReadLine();

                Console.Write("Enter the substring to insert: ");
                string insert = Console.ReadLine();

                int position = -1;

                if (search.Length > 0)
                {
                    for (int i = 0; i <= text.Length - search.Length; i++)
                    {
                        bool match = true;

                        for (int j = 0; j < search.Length; j++)
                        {
                            if (text[i + j] != search[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            position = i;
                            break;
                        }
                    }
                }

                if (position != -1)
                {
                    string result = "";

                    for (int i = 0; i < position; i++)
                    {
                        result += text[i];
                    }

                    result += insert;

                    for (int i = position; i < text.Length; i++)
                    {
                        result += text[i];
                    }

                    Console.WriteLine("Result = " + result);
                }
                else
                {
                    Console.WriteLine("Substring not found.");
                }
            }
            #endregion
        }
    }
}
