string str = "1d";
int a;
bool result  = int.TryParse(str, out a);
Console.WriteLine(result);