using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTransition : Transition
{
    Player player;
    public UpTransition(Player _player)
    {
        player = _player;
        nextState = new UpState(_player);

    }


    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count != 0)
        {
            if (player.GetInputMgr.Commands[0].Name == "UpCommand" && player.DisplayActtualy == 0)
                return true;
        }
        return false;
    }
}
