using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTransition : Transition
{
    Player player;
    public DownTransition(Player _player)
    {
        player = _player;
        nextState = new DownState(_player);
    }

    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count != 0)
        {
            if (player.GetInputMgr.Commands[0].Name == "DownCommand" && player.DisplayActtualy == 0)
                return true;
        }

        return false;
    }
}
