﻿// See https://aka.ms/new-console-template for more information

using Sprache;

Parser<Color> parseColor = Parse.Identifier(Parse.Letter, Parse.Letter)
                                .Select(v => v switch
                                             {
                                                 "red" => Color.Red,
                                                 "green" => Color.Green,
                                                 "blue" => Color.Blue,
                                                 _ => throw new InvalidOperationException($"Unknown color '{v}'"),
                                             });

Parser<CubeSet> parseCubeSet =
    from _ in Parse.WhiteSpace.Many()
    from count in Parse.Number.Select(int.Parse)
    from space in Parse.WhiteSpace
    from c in parseColor
    select new CubeSet(c, count);

Parser<Grab> parseGrab =
    from set in parseCubeSet.DelimitedBy(Parse.Char(','))
    select new Grab(set.ToArray());

Parser<Grab[]> parseGameGrabs =
    from g in parseGrab.DelimitedBy(Parse.Char(';'))
    select g.ToArray();

Parser<Game> parseGame =
    from _ in Parse.String("Game ")
    from id in Parse.Number.Select(int.Parse)
    from __ in Parse.String(": ")
    from grabs in parseGameGrabs
    select new Game(id, grabs);

Parser<IEnumerable<Game>> parseGames =
    parseGame.DelimitedBy(Parse.LineEnd);

// const string input =
//     "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
const string input =
    "Game 1: 7 green, 4 blue, 3 red; 4 blue, 10 red, 1 green; 1 blue, 9 red\nGame 2: 2 red, 4 blue, 3 green; 5 green, 3 red, 1 blue; 3 green, 5 blue, 3 red\nGame 3: 12 red, 1 blue; 6 red, 2 green, 3 blue; 2 blue, 5 red, 3 green\nGame 4: 3 green, 1 red, 3 blue; 1 red; 2 green, 1 red, 1 blue; 3 green, 1 blue; 2 blue; 2 green, 4 blue\nGame 5: 3 blue, 3 red, 8 green; 5 blue, 1 red; 1 green, 19 blue, 3 red; 1 red, 5 green, 3 blue; 4 green, 20 blue, 4 red; 20 blue, 4 green\nGame 6: 7 green, 6 blue, 1 red; 3 blue, 5 green, 3 red; 9 blue, 3 red, 6 green; 8 blue, 11 green, 3 red; 2 blue, 1 red; 7 green, 4 blue, 1 red\nGame 7: 5 green, 1 blue; 2 green, 2 blue; 1 blue, 1 red; 5 blue, 2 green; 3 green\nGame 8: 5 blue, 5 red, 10 green; 6 green, 1 blue, 1 red; 5 red, 2 blue, 16 green; 2 blue, 14 green, 9 red; 9 red, 3 green, 7 blue; 8 red, 4 blue, 10 green\nGame 9: 1 red, 1 blue, 7 green; 4 red, 6 green, 2 blue; 6 green, 14 blue, 3 red\nGame 10: 1 red, 16 green, 3 blue; 1 red, 3 blue; 6 green; 4 green, 2 blue, 1 red\nGame 11: 5 red, 2 blue; 14 blue, 8 red, 10 green; 8 green, 1 red, 15 blue; 2 green, 5 red, 11 blue; 8 red, 11 blue, 4 green\nGame 12: 5 green, 8 blue, 4 red; 15 green, 8 blue, 8 red; 13 red, 1 blue; 6 blue, 7 green, 14 red; 9 red\nGame 13: 7 blue, 5 red; 3 green, 10 blue; 5 blue, 2 green, 5 red; 3 blue, 1 green, 5 red; 6 blue, 4 red, 6 green; 5 red, 2 green, 6 blue\nGame 14: 5 red, 1 blue, 5 green; 6 blue, 13 green, 4 red; 7 blue, 4 red, 1 green; 6 blue, 5 red; 2 red, 7 blue, 2 green\nGame 15: 8 red, 16 green; 10 green, 1 blue; 16 green, 7 blue, 3 red; 13 red, 7 blue, 8 green; 4 red, 2 green, 8 blue\nGame 16: 1 red, 1 blue, 5 green; 5 green, 2 red; 2 green, 1 red; 3 red, 4 green\nGame 17: 3 green, 7 blue, 5 red; 2 red, 1 blue; 8 blue, 1 red\nGame 18: 9 green, 6 blue, 3 red; 3 red, 15 green, 5 blue; 7 green, 3 red, 3 blue\nGame 19: 4 green, 3 red, 7 blue; 4 blue, 6 red, 4 green; 6 red, 5 green, 1 blue; 6 blue, 4 green, 3 red; 5 green, 5 red, 2 blue\nGame 20: 3 green, 5 blue, 1 red; 1 red, 1 blue; 1 red, 6 blue; 1 green, 4 blue\nGame 21: 2 green, 1 blue, 3 red; 16 green, 1 blue, 4 red; 11 green, 2 red, 1 blue; 6 green, 1 blue; 10 green, 1 red, 1 blue\nGame 22: 1 blue, 2 green, 4 red; 3 red, 4 green; 1 blue, 3 red, 10 green; 7 green, 1 blue\nGame 23: 2 red, 14 blue; 2 red, 14 blue; 1 red, 14 blue, 1 green; 1 red, 6 blue; 13 blue, 1 green\nGame 24: 3 green, 7 blue, 3 red; 4 green, 2 blue; 12 blue, 8 red, 4 green; 10 blue, 9 red, 1 green; 13 blue, 4 red; 12 blue, 9 red, 2 green\nGame 25: 9 green, 11 red; 14 green, 3 red, 1 blue; 8 red, 7 green; 10 red, 8 green, 1 blue; 6 red, 11 green, 1 blue\nGame 26: 10 blue, 6 red, 11 green; 9 red, 2 green, 10 blue; 5 red; 9 red, 8 blue, 7 green; 13 green, 10 red, 1 blue\nGame 27: 3 blue, 1 green; 10 green, 1 blue; 8 red, 6 green, 6 blue\nGame 28: 10 blue, 2 red, 13 green; 2 blue, 2 red, 6 green; 10 blue; 4 red, 4 blue, 11 green; 3 green, 2 red, 6 blue; 14 green, 2 red, 2 blue\nGame 29: 8 blue, 5 red, 6 green; 1 green, 4 blue, 15 red; 8 blue, 14 red, 3 green; 9 blue, 4 red, 5 green; 3 red, 3 green, 4 blue\nGame 30: 19 green, 14 blue, 2 red; 2 red, 8 green, 7 blue; 4 blue, 1 red, 13 green; 10 blue, 3 green; 8 blue, 2 red\nGame 31: 12 green, 5 blue, 3 red; 15 blue, 11 green, 6 red; 6 green, 6 red; 4 green, 6 blue, 10 red\nGame 32: 7 red, 2 green, 3 blue; 9 red, 1 green; 2 green, 5 red, 1 blue; 12 red; 14 red, 4 blue\nGame 33: 9 red, 4 green, 6 blue; 4 red, 10 green; 16 red, 4 green, 4 blue; 15 blue, 12 red\nGame 34: 5 green, 1 blue; 18 red, 1 green, 1 blue; 1 blue, 9 green, 3 red; 6 green, 11 red\nGame 35: 2 blue, 19 green, 6 red; 16 green, 1 red, 1 blue; 1 green, 2 blue, 5 red; 8 green, 3 blue, 13 red; 11 red, 10 green, 4 blue\nGame 36: 17 green, 6 blue; 10 blue, 2 red, 8 green; 16 green, 4 blue, 1 red\nGame 37: 9 green, 7 red, 8 blue; 1 blue, 10 red; 10 red, 4 blue, 11 green; 8 green, 11 red, 5 blue\nGame 38: 8 green, 11 blue; 13 green, 2 blue; 7 blue, 2 red, 8 green\nGame 39: 14 red, 2 green; 2 red, 3 green, 1 blue; 4 red, 5 green, 4 blue; 2 blue, 3 red, 1 green; 17 red, 2 blue; 5 green, 3 red\nGame 40: 10 blue; 2 red, 9 blue; 5 red, 1 green, 2 blue; 8 blue, 2 red; 6 blue, 2 red; 4 red, 2 blue, 1 green\nGame 41: 2 blue, 3 red, 2 green; 4 green, 2 red, 11 blue; 11 blue, 3 red, 1 green; 1 red, 6 green, 1 blue; 5 red, 7 green\nGame 42: 1 blue, 14 green, 1 red; 2 blue, 2 green; 5 green, 2 blue, 8 red\nGame 43: 15 red, 5 blue, 5 green; 15 green, 15 red, 1 blue; 4 blue, 13 green, 13 red; 3 red, 16 green; 2 red, 3 green, 2 blue\nGame 44: 8 green, 8 blue; 9 blue, 9 green; 9 green, 3 blue; 8 green, 3 blue; 8 blue, 2 green; 9 blue, 1 red, 8 green\nGame 45: 4 red, 4 blue, 4 green; 5 red, 2 green, 9 blue; 8 blue, 5 red, 3 green; 4 red, 3 blue; 5 red, 5 green, 1 blue\nGame 46: 1 blue, 9 green, 2 red; 2 blue, 9 green, 1 red; 8 green, 3 red\nGame 47: 2 green, 4 blue, 10 red; 4 green, 5 blue, 1 red; 10 green, 13 red, 6 blue; 4 green, 4 blue, 12 red; 15 red, 1 blue, 4 green\nGame 48: 1 red, 7 green; 2 blue, 4 green, 5 red; 5 red, 3 green, 1 blue; 8 green\nGame 49: 3 blue, 4 green, 3 red; 6 red, 5 green, 5 blue; 1 blue, 4 green, 3 red; 6 red, 1 blue, 5 green; 4 red, 3 green, 5 blue; 2 green, 3 blue, 1 red\nGame 50: 1 green, 5 red, 6 blue; 3 red, 2 green; 1 red, 1 green, 6 blue; 1 green, 7 red, 3 blue\nGame 51: 7 green, 8 blue; 6 blue, 6 red, 4 green; 6 green, 1 blue; 8 blue, 5 red, 4 green\nGame 52: 7 red, 3 blue, 6 green; 7 green, 5 red, 4 blue; 6 red, 4 blue\nGame 53: 12 blue, 1 red, 5 green; 4 green, 2 blue, 5 red; 5 red, 4 green; 1 green, 3 blue, 5 red; 5 blue, 2 red, 5 green\nGame 54: 15 green, 12 red; 11 red, 3 green, 2 blue; 3 blue, 6 green; 3 red, 1 blue, 5 green; 17 red, 7 green\nGame 55: 7 green, 10 red, 7 blue; 8 red, 4 blue, 11 green; 9 green, 11 red\nGame 56: 7 green, 3 blue, 5 red; 6 green, 1 red, 4 blue; 4 green, 2 red; 5 blue, 6 red, 8 green\nGame 57: 1 green, 3 red, 3 blue; 5 blue, 2 red, 2 green; 1 green, 5 blue\nGame 58: 4 red, 2 green; 13 green, 4 red, 1 blue; 12 green, 4 blue\nGame 59: 4 red, 4 green; 5 blue, 1 green, 20 red; 11 red, 3 green, 15 blue; 5 blue, 7 red, 3 green; 18 blue, 4 green, 19 red\nGame 60: 5 blue, 8 red, 4 green; 4 blue, 12 green, 19 red; 3 blue, 1 green, 17 red; 1 green, 3 blue; 2 green, 6 blue, 3 red\nGame 61: 3 red, 7 blue, 12 green; 7 red, 1 green, 6 blue; 6 red, 2 green, 18 blue; 14 blue, 5 red, 1 green\nGame 62: 1 red, 2 blue; 1 green, 3 red; 1 green, 9 blue, 4 red\nGame 63: 6 green, 4 blue, 17 red; 2 green, 2 blue, 12 red; 10 green, 9 blue, 13 red; 15 red, 8 green, 5 blue\nGame 64: 4 green, 7 blue, 10 red; 3 green, 4 blue, 12 red; 6 green, 6 red, 8 blue; 4 green, 9 red, 1 blue; 2 blue, 15 red, 15 green\nGame 65: 5 green, 4 blue, 7 red; 6 green, 7 blue, 8 red; 1 green, 7 red; 1 blue, 10 red, 8 green\nGame 66: 5 green, 5 blue, 2 red; 3 red; 1 red, 1 blue, 16 green; 2 blue, 1 green; 8 green, 1 blue, 3 red; 14 green, 4 red\nGame 67: 12 blue, 7 green; 7 blue, 7 green, 1 red; 12 blue, 1 green, 6 red\nGame 68: 2 blue, 8 red, 1 green; 9 blue, 3 green, 12 red; 14 blue, 15 red, 6 green\nGame 69: 7 red, 1 blue; 11 green, 2 blue, 13 red; 3 blue, 13 green, 3 red; 1 blue, 10 red, 8 green; 15 red, 2 blue, 19 green\nGame 70: 10 green, 10 red, 12 blue; 7 red, 15 blue, 2 green; 8 blue, 9 green\nGame 71: 1 blue, 2 green, 13 red; 7 red; 1 green, 5 red\nGame 72: 2 red, 1 blue, 11 green; 1 red, 2 blue, 18 green; 5 red, 3 blue, 3 green\nGame 73: 13 red, 3 blue, 4 green; 3 green, 17 red, 1 blue; 6 blue, 4 green, 4 red; 13 red, 7 blue\nGame 74: 1 blue, 3 red; 13 blue, 5 red, 2 green; 1 red, 8 green, 11 blue; 4 blue, 1 green, 5 red; 11 blue, 8 red, 6 green; 8 red, 3 green, 4 blue\nGame 75: 7 blue, 4 green, 1 red; 3 green, 4 blue; 5 green, 2 red, 3 blue; 6 blue, 3 red, 5 green\nGame 76: 9 green, 1 blue, 4 red; 6 red, 9 green, 3 blue; 2 red, 6 green, 2 blue; 5 green; 6 green, 2 red, 3 blue; 6 blue, 5 red, 5 green\nGame 77: 2 green, 2 red; 1 blue, 6 red, 2 green; 4 green, 3 red, 2 blue; 2 blue, 1 green, 1 red\nGame 78: 2 green, 10 red, 2 blue; 6 green, 2 red, 2 blue; 2 blue, 9 red, 6 green; 11 red, 6 green; 3 red, 8 green; 1 blue, 6 green, 1 red\nGame 79: 3 blue, 8 green, 13 red; 3 blue, 2 red, 3 green; 10 red, 6 green, 4 blue; 11 red, 1 blue, 3 green\nGame 80: 3 green, 5 red, 9 blue; 3 red, 5 blue, 2 green; 5 green, 6 red, 2 blue\nGame 81: 2 green, 7 blue, 3 red; 9 blue, 3 red; 1 green, 17 blue, 2 red\nGame 82: 4 green, 8 blue, 7 red; 10 blue, 1 green, 10 red; 7 blue, 4 green, 5 red\nGame 83: 7 green, 4 blue, 3 red; 15 blue, 3 red, 14 green; 9 blue, 4 red, 7 green\nGame 84: 5 red, 5 green; 16 blue, 1 red, 7 green; 17 blue, 11 red\nGame 85: 7 red, 1 green, 11 blue; 13 blue, 5 green, 6 red; 11 blue, 2 green, 8 red; 5 blue, 17 red, 4 green; 12 blue, 2 green, 8 red\nGame 86: 3 red, 8 blue, 2 green; 15 green, 15 blue, 2 red; 18 blue, 2 red, 11 green\nGame 87: 1 blue; 6 red, 6 green; 1 blue, 9 red, 3 green\nGame 88: 10 green, 2 blue, 1 red; 7 blue, 1 green, 1 red; 9 green, 4 blue; 8 green, 1 red, 7 blue\nGame 89: 6 green, 2 red, 2 blue; 5 red, 3 blue, 3 green; 3 blue, 4 red, 1 green; 5 red, 4 green, 5 blue; 4 blue, 6 green, 3 red; 3 red, 1 green\nGame 90: 1 green, 6 blue; 1 blue, 1 red; 2 blue, 3 green; 7 green, 6 blue; 1 red, 7 green, 6 blue\nGame 91: 8 blue, 14 green, 5 red; 8 red, 6 green; 4 red, 7 blue, 14 green; 4 blue, 7 green; 9 blue, 7 red; 14 green, 7 blue, 4 red\nGame 92: 11 blue, 8 green, 6 red; 11 blue, 1 red, 11 green; 10 blue, 19 green, 5 red\nGame 93: 5 green, 1 red, 7 blue; 8 green, 14 blue, 2 red; 5 red, 14 blue, 7 green\nGame 94: 2 blue, 6 red, 3 green; 4 red, 2 green, 2 blue; 4 red, 1 blue, 1 green\nGame 95: 9 red, 15 green, 1 blue; 2 blue, 10 red, 18 green; 3 red, 10 green; 10 red, 17 green, 2 blue; 3 blue, 13 green, 1 red; 2 red, 2 blue, 6 green\nGame 96: 8 green, 1 blue; 1 blue, 1 red, 11 green; 2 green, 15 blue; 1 red, 2 green, 1 blue\nGame 97: 3 green, 3 blue; 5 green, 3 blue, 1 red; 5 green, 1 red, 3 blue; 1 green, 1 red, 2 blue; 2 green, 2 blue, 3 red\nGame 98: 6 red, 6 green, 5 blue; 19 red, 7 green; 6 green, 8 blue, 4 red; 10 green, 4 red\nGame 99: 9 red, 8 blue, 10 green; 3 blue, 7 green, 8 red; 6 red, 12 blue; 8 blue, 8 green, 2 red; 16 green, 14 blue, 5 red\nGame 100: 8 red, 13 green; 5 red, 4 green; 7 blue, 3 red, 8 green; 13 blue, 6 green; 1 blue, 8 green, 7 red; 2 red, 1 green, 16 blue";

var allGames = parseGames.Parse(input).ToArray();

foreach (var g in allGames)
{
    Console.WriteLine($"{g.Id}: {(g.IsPossible() ? "possible" : "not possible")}");
}

int part1 = allGames.Where(g => g.IsPossible()).Select(g => g.Id).Sum();
Console.WriteLine(part1);

int part2 = allGames.Select(g => g.Power()).Sum();
Console.WriteLine(part2);

internal record CubeSet(Color Color, int Count);

internal record Grab(CubeSet[] Sets);

internal record Game(int Id, Grab[] Grabs)
{
    private const int _maxRedCubes = 12;
    private const int _maxGreenCubes = 13;
    private const int _maxBlueCubes = 14;

    public bool IsPossible() => Grabs.SelectMany(g => g.Sets)
                                     .All(s => s.Count <= s.Color switch
                                                          {
                                                              Color.Red => _maxRedCubes,
                                                              Color.Green => _maxGreenCubes,
                                                              Color.Blue => _maxBlueCubes,
                                                              _ => throw new ArgumentOutOfRangeException(),
                                                          });

    public int Power() =>
        Grabs.SelectMany(g => g.Sets)
             .GroupBy(g => g.Color, (_, items) => items.MaxBy(s => s.Count)!.Count)
             .Aggregate(1, (total, current) => total * current);
}

internal enum Color
{
    Red,
    Green,
    Blue,
}