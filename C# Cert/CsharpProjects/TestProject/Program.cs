// use do-while or while as outer game loop
// hero and monster start with 10 hp
// all attacks value between 1-10
// hero attacks first
// print amount of health monster lost and remaining health
// if monster health greater than 0, monster can attack
// print amount of health the hero lost and their remaining health
// continue sequence until monster or hero health 0 or less. 
// print winner 

int heroHealth = 10;
int monsterHealth = 10;
Random attack = new Random();
string winner = "none";

for (int i = 0; i < 10; i++)
{
    do
    {
        // hero attacks first
        int heroAttack = attack.Next(1, 11);
        monsterHealth -= heroAttack;
        Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

        // if monster has health, can attack
        if (monsterHealth > 0)
        {
            int monsterAttack = attack.Next(1, 11);
            heroHealth -= monsterAttack;
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            // check hero health after monster attack
            if (heroHealth > 0)
                continue;
            else winner = "Monster";
        }
        else winner = "Hero";

    } while (winner == "none");

    Console.WriteLine($"{winner} wins!");
    heroHealth = 10;
    monsterHealth = 10;
}

