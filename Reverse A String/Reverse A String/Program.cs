// See https://aka.ms/new-console-template for more information
/* 
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
*/

string str = "Tumi is my fav developer";
char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
{
    if (i == 'e')
    {
        x++;
    }
}
string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'e' appears {x} times.");
