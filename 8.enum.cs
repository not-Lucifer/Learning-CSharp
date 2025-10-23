using System;
enum PlayerState
{
    attacking,
    idle,
    defensive
}

PlayerState NPC = PlayerState.idle;
Console.WriteLine(NPC);