Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    string temp = "";
    if (i % 3 == 0) temp += "foo";
    if (i % 5 == 0) temp += "bar";
    if (i % 7 == 0) temp += "jazz";

    Console.Write(temp == "" ? i : temp);

    if (i != number) Console.Write(", ");
}

