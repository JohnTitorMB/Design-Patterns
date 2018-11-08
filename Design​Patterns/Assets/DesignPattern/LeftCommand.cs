using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftCommand : Command
{
    Player player;
    public LeftCommand(Player _player, float _time)
    {
        player = _player;
        m_time = _time;

        name = "LeftCommand";
    }

    public override void execute()
    {
        player.DisplayLeft();
    }

}