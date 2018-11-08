using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : Command
{
    Player player;
    public RightCommand(Player _player, float _time)
    {
        player = _player;
        m_time = _time;

        name = "RightCommand";
    }

    public override void execute()
    {
        player.DisplayRight();
    }

}