using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCommand : Command
{
    Player player;
    public UpCommand(Player _player, float _time)
    {
        player = _player;
        m_time = _time;

        name = "UpCommand";
    }

    public override void execute()
    {
        player.DisplayUp();
    }

}
