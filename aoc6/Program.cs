// var input = new[]
//             {
//                 new Game(7, 9),
//                 new Game(15, 40),
//                 new Game(30, 200),
//             };
// var aggregateGame = new Game(71530, 940200);
var input = new[]
            {
                new Game(57, 291),
                new Game(72, 1172),
                new Game(69, 1176),
                new Game(92, 2026),
            };
var aggregateGame = new Game(57726992, 291117211762026);

int part1 = input.Select(game => game.NumberOfWaysToBeatRecord())
                 .Aggregate(1, (a, b) => a * b);
Console.WriteLine(part1);

int part2 = aggregateGame.NumberOfWaysToBeatRecord();
Console.WriteLine(part2);

internal record Game(int Duration, long Distance)
{
    public int NumberOfWaysToBeatRecord()
    {
        int result = 0;

#if DEBUG
        checked
        {
#endif
            for (int buttonHeldFor = 1; buttonHeldFor < Duration; buttonHeldFor++)
            {
                int speed = buttonHeldFor;
                int timeRemaining = Duration - buttonHeldFor;
                long distanceTraveled = (long) speed * timeRemaining;

                if (distanceTraveled > Distance)
                {
                    result++;
                }
            }
#if DEBUG
        }
#endif

        return result;
    }
}