// See https://aka.ms/new-console-template for more information

string greeting = "Hello, World Hello, Hello!";
int number = 10;
double decimalNumber = 15.78;
char simbol = 'm';
bool answer = false;


Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalNumber);
Console.WriteLine(simbol);
Console.WriteLine(answer);

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

int num1 = 5;
int num2 = 2;

int sum = num1 + num2;
int diff = num1 - num2;
int multiply = num1 * num2;
double convertedNum2 = (double)num2;
double divide = num1 / convertedNum2;

int leftAfter = num1 % num2;
// pilnais pieraksts num1 = num1 + 1;
num1++;
// pilnais pieraksts num2 = num2 - 1;
num2--;



Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(leftAfter);
Console.WriteLine(num1);
Console.WriteLine(num2);


Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine();


int num3 = 9;
int num4 = 5;

bool isEqual = num3 == num4;
bool isNotEqual = num3 != num4;
bool isLarger = num3 > num4;
bool isSmaller = num3 < num4;
bool isLargerEqual = num3 >= num4;
bool isSmallerEqual = num3 <= num4;





Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);


Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine();


bool isTrue = true;
bool isFalse = false;

bool isBoth = isTrue && isFalse;
bool isEitherOne = isTrue || isFalse;
bool converted = !isTrue;

Console.WriteLine(isBoth);
Console.WriteLine(isEitherOne);
Console.WriteLine(converted);


Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine();

int num5 = 5;
int num6 = 6;

num5 += 2; // pilnais pieraksts num5 = num5 + 2


Console.WriteLine(num5);

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine();

// 1. Pajautāt lietotājam ievadīt skaitli
Console.WriteLine("Lūdzu ievadi skaitli?");
// 2. Sagaidīt lietotāja skaitļa ievadi
string userNumberText = Console.ReadLine();
int userNumber = int.Parse(userNumberText);

// 3. Formatēta tekstā izvadīt lietotāja skaitli palielinātu par 2
int result = userNumber + 2;
Console.WriteLine("Tavs skaitlis palielinats par 2:" + result);


int x = 4;
int y = 9;

int absoluteNumber = Math.Min Abs(x);


Console.WriteLine(absoluteNumber);


Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine();

string name = "Nadezhda";
int age = 40;


Console.WriteLine("Sveika" + name + age + "!");
Console.WriteLine($"Sveika" + {name});
Console.WriteLine("Sveika" + name + "!");


