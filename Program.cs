using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Player
{
    public string name;
    public int age;
    public int jersey_number;
};
public class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Enter the number of Players:");
        num = Convert.ToInt32(Console.ReadLine());
        Player[] p = new Player[num];
        for(int i=0;i<num;i++)
        {
            Console.WriteLine("Player " + (i+1));
            Console.Write("Enter the name of the player:");
            p[i].name = Console.ReadLine();
            Console.Write("Enter the age of the player:");
            p[i].age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the jersey number of the player:");
            p[i].jersey_number = Convert.ToInt32(Console.ReadLine());
        }
        string path = @"C:\Users\usera\OneDrive\Desktop\C#\player.txt";
        using (StreamWriter sw = File.AppendText(path))
        {
            for(int j=0;j<num;j++)
            {
                sw.WriteLine(p[j].name + " of Jersey number " + p[j].jersey_number + " is " + p[j].age + " years old.");
            }
            sw.Close();
            Console.WriteLine(" ");
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}