int heroHealth = 10;
int monsterHealrh = 10;

Random random = new Random();

//star fight

do
{
    //Hero atack
    int heroAttack = random.Next(1, 11);
    int monsterHealth = heroAttack;

    Console.WriteLine ($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");

    //Let's check if the monster is alive
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins");
        break;
    }

    //AtackAttack the monster if it is still alive
    int monsterAttack = random.Next(1, 11);
    heroHealth -= monsterAttack;

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

    //Lets check if the hero is alive

    if (heroHealth <= 0)
    {
    Console.WriteLine("Monster Wins");
    break;
    }
} while (heroHealth > 0 && monsterHealrh >0);