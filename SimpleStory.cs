using System;

Console.Clear();
Console.WriteLine("Greetings, adventurer.");
System.Threading.Thread.Sleep(1000);
Console.WriteLine(
    "Press any key to progress, and either 'a' or 'b' when prompted..."
);
Console.ReadKey();
System.Threading.Thread.Sleep(100);
Console.WriteLine(
    "\n\n\tThe sun is close to setting and you have been on a journey to find food and water for what seems like forever.\n\tYou are in a dark forest, lost, and your stomach is rumbling.\n"
);
Console.ReadKey();
System.Threading.Thread.Sleep(100);
Console.WriteLine(
    "\n\n\tYou look to your right and see a watermelon and a potato. Maybe someone is looking out for you. \n\tHowever, you hear some growling nearby and you realise you can only grab one thing before running away.\n\tWhich do you choose? The watermelon (a) or the potato (b)?\n"
);
var food = Console.ReadKey().Key;
System.Threading.Thread.Sleep(100);

while (food != ConsoleKey.A && food != ConsoleKey.B)
{
    Console.WriteLine("\n\n\tOnly two options exist! Watermelon (a) or potato (b)? You must choose one!\n");
    food = Console.ReadKey().Key;
}

if (food == ConsoleKey.A)
{
    Console.WriteLine("\n\n\tWatermelon. Good choice.");
    Console.WriteLine("\n\tYou grab it and chomp down on it straight away while running for your life.\n\tThank god it's so watery, it hydrates you immediately.\n\tThe bliss is however cut short, as the sun is clearly gone now.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\n\tThe growls from earlier have caught up with you.\n\tYou look behind you to see a green-faced creature headed your way.\n\tPanicked, you start climbing the nearby hill.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tThe creature seemed to follow you for a while before you heard some strange, unfamiliar noises.\n\tYou look down to see a skeleton and the creature fighting each other.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\t'Phew...' You think to yourself.\n\tYou are safe from the monsters for now.");

}
else if (food == ConsoleKey.B)
{
    Console.WriteLine("\n\n\tPotato. Questionable choice.");
    Console.WriteLine("\n\n\tYou pick it up and notice it's mushy and slimy.\n\tOn closer look, it looks poisoned. You can't eat that.\n\tThe sun has now set completely and the growl suddenly feels dangerously close.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tYou look behind you to see a green-faced creature. All of a sudden you don't feel hunger anymore.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tPanicked and desperate, you throw the potato right at it and run.\n\tThankfully the creature decided to leave you alone.\n\tYou decide to climb the hill nearby to not come across it again.");
}
Console.ReadKey();
System.Threading.Thread.Sleep(100);
Console.WriteLine("\n\tThe hill seems safe for the most part.\n\tYou decide to look around sneakily to make sure very recent history does not repeat itself.");

Console.ReadKey();
System.Threading.Thread.Sleep(100);
Console.WriteLine("\n\tAfter a while of scouting and sneaking, you come across two paths. You must choose 'a' or 'b'.\n\n\t\tWhich will it be? 'a' or 'b'?");

var path = Console.ReadKey().Key;
System.Threading.Thread.Sleep(100);

while (path != ConsoleKey.A && path != ConsoleKey.B)
{
    Console.WriteLine("\n\n\tOnly two paths exist!  You must choose one of them!\n");
    path = Console.ReadKey().Key;
}

if (path == ConsoleKey.A)
{
    Console.WriteLine("\n\n\tThis path leads you towards a cherry blossom forest.");
    Console.WriteLine("\n\tIt looks beautiful from afar and draws you in.\n\tYou have never seen so much pink before.\n\tThe sky is now turning from black to a light blue, the sun will come back up soon.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\n\tOnce you reach the forest you realise that the serene beauty you saw does not hold up close.\n\tYour earlier fears have returned.\n\tThe green creatures are everywhere now joined by other, even greener, strange creatures.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tYou once again panic. Only this time there's nowhere to run.\n\tThe monsters are moving towards you, growling. You have lost your hope when suddenly...");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);

}
else if (path == ConsoleKey.B)
{
    Console.WriteLine("\n\n\tThis path leads you towards a mountain of snow and ice.");
    Console.WriteLine("\n\n\tIt looks beautiful and mysterious from afar.\n\tAs you draw in closer it looks even more captivating.\n\tThe sky is now turning from black to a lighter shade and the snow is clearly glistening.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tOnce you reach the mountain you realise that the mystery was well-founded.\n\tAs you look down you realise you are surrounded by hundreds of skeletons with bows. This has got to be a joke.");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);
    Console.WriteLine("\n\tYou panic once gain. Only this time there's nowhere to run. They can also see you and are headed your way.\n\tYou lose all your hope when suddenly...");
    Console.ReadKey();
    System.Threading.Thread.Sleep(100);

}
Console.WriteLine("\n\tThe sky illuminates with enormous sun rays and the creatures in front of you burst into flames!\n\tThis has been such a strange night...");
Console.ReadKey();
System.Threading.Thread.Sleep(100);
Console.WriteLine("\n\t\tFrom now on you decide to never explore this place at night.");
Console.ReadKey();