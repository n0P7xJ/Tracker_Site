using System;
using MyProject;



class Program
{
    static void Main()
    {
        InpolTracker tracker = new InpolTracker();

        tracker.Test("https://inpol.mazowieckie.pl/login");
    }
}
