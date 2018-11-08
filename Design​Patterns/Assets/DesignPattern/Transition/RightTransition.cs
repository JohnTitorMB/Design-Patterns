using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTransition : Transition
{
    Player player;
    public RightTransition(Player _player)
    {
        player = _player;
        nextState = new RightState(_player);


    }


    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count != 0)
        {
            if (player.GetInputMgr.Commands[0].Name == "RightCommand" && player.DisplayActtualy == 0)
                return true;
        }

        return false;
    }
}

