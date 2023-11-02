Console.Write("Введите сумму в рублях: ");
string strNum = Console.ReadLine(); 
double num = double.Parse(strNum);

double result = num*0.1;
Console.WriteLine(num + "рублей = " + result + "долларов");


