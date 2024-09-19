Random random = new Random();

int money = 10000;

Console.WriteLine("Welcome to this casino´s roulette table! You have ${0}. Press enter to start.", money);
Console.ReadLine();

while (money >= 0)
{
    Console.WriteLine("How much would you like to bet?");
    int bet = Convert.ToInt32(Console.ReadLine());

    if (bet > 0 && bet < money)
    {
        Console.WriteLine("Which number would you like to bet on? Choose a number between 0 and 36");
        int betnumber = Convert.ToInt32(Console.ReadLine());
        
        if (betnumber >= 0 && betnumber <= 36)
        {
            int rouletteResult = random.Next(0, 37);
            int rouletteBait0 = random.Next(0, 37);
            int rouletteBait1 = random.Next(0, 37);
            int rouletteBait2 = random.Next(0, 37);

            Console.WriteLine("You tell the dealer to roll...and it rolls. It bounces on {0}, close shave on {1}, barely bounces of {2}, when it finally lands on...", rouletteBait0, rouletteBait1, rouletteBait2);
            Thread.Sleep(4000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(500);

            Console.WriteLine(rouletteResult + "!");

            if (betnumber == rouletteResult)
            {
                int prize = bet * 35;
                money += prize;
                Console.WriteLine("You just won ${0}!! You now have ${1}", prize, money);
            }
            else
            {
                money -= bet;
                Console.WriteLine("You just lost. You now have ${0}.", money);
            }
        }
        else
        {
            Console.WriteLine("Wrong input. Only numbers between 0 and 36 are allowed.");
        }
    }
}