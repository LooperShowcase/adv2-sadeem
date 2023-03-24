using System.Security.Cryptography.X509Certificates;

Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;



Console.WriteLine("welcome to SADEEM game");
char[] lines = { '_', '_', '_', '_' };
for (int i = 0; i < lines.Length; i++)
{
    Console.Write(lines[i] + " ");
}
string nth = gettodayword();
int heart = gettodayword().Length;
while (heart > 0)
{
    char c = askUser();
    int result = checkletter(nth, c, lines);

    if (result == -1)
    {
        heart--;
        Console.WriteLine("u have " + heart + " heats left");
    }
    else
    {
        lines[result] = c;
    }
     
    if (heart == 0)
    {
        Console.WriteLine("U LOSE");
    }



}



static char askUser()
{
    Console.WriteLine("Please enter a char:");
    char c = Console.ReadLine()[0];
    return c;

}

static string gettodayword()

{
    string[] arr = { "moon", "call", "more", "nike", "damn" };
    Random rnd = new Random();
    int num = rnd.Next(1, arr.Length);
    return arr[num];
}

static int checkletter(string todayword, char ch, char[] lines)
{
    for (int i = 0; i < todayword.Length; i++)
    {
        if (todayword[i] == ch && lines[i] != ch)
        {
            return i;
        }
    }
    return -1;
}
 static int checkWin(string todayword, char[] lines)
{
    for (int i = 0; i <= lines.Length; i++)
    {
        if (lines[i] != '_')
        {
            return -1;
        }
       
    }
    return 1;
}
{
     static void pri
}
