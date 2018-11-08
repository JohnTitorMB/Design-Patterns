using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTransition : Transition
{
    Player player;
    public LeftTransition(Player _player)
    {
        player = _player;
        nextState = new LeftState(_player);

    }

    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count != 0)
        {
            if (player.GetInputMgr.Commands[0].Name == "LeftCommand" && player.DisplayActtualy == 0)
                return true;
        }

        return false;
    }
}
