using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DownCommand : Command
{
    Player player;
    public DownCommand(Player _player, float _time)
    {
        player = _player;
        m_time = _time;
        name = "DownCommand";
    }

    public override void execute()
    {
        player.DisplayDown();
    }

}