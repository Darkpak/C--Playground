using System;

string input = "R5, R4, R2, L3, R1, R1, L4, L5, R3, L1, L1, R4, L2, R1, R4, R4, L2, L2, R4, L4, R1, R3, L3, L1, L2, R1, R5, L5, L1, L1, R3, R5, L1, R4, L5, R5, R1, L185, R4, L1, R51, R3, L2, R78, R1, L4, R188, R1, L5, R5, R2, R3, L5, R3, R4, L1, R2, R2, L4, L4, L5, R5, R4, L4, R2, L5, R2, L1, L4, R4, L4, R2, L3, L4, R2, L3, R3, R2, L2, L3, R4, R3, R1, L4, L2, L5, R4, R4, L1, R1, L5, L1, R3, R1, L2, R1, R1, R3, L4, L1, L3, R2, R4, R2, L2, R1, L5, R3, L3, R3, L1, R4, L3, L3, R4, L2, L1, L3, R2, R3, L2, L1, R4, L3, L5, L2, L4, R1, L4, L4, R3, R5, L4, L1, L1, R4, L2, R5, R1, R1, R2, R1, R5, L1, L3, L5, R2"; // Replace with your input

var directions = new (int dx, int dy)[] { (0, 1), (1, 0), (0, -1), (-1, 0) }; // N, E, S, W
int x = 0, y = 0, dir = 0; // Start at (0,0), facing North (0)

foreach (var instruction in input.Split(',', StringSplitOptions.TrimEntries))
{
    char turn = instruction[0];
    int steps = int.Parse(instruction[1..]);

    dir = (dir + (turn == 'R' ? 1 : 3)) % 4; // Right: +1, Left: +3 (mod 4)
    x += directions[dir].dx * steps;
    y += directions[dir].dy * steps;
}

Console.WriteLine($"Blocks away: {Math.Abs(x) + Math.Abs(y)}");