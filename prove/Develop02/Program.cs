using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        do {
            menu.Run();
        } while(!menu.IsFinished());
    }
}