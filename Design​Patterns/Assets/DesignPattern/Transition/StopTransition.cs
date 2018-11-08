using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTransition : Transition
{
    Player player;
    public StopTransition(Player _player)
    {
        player = _player;
        nextState = new StopingState(_player);
    }

    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count == 0)
            return true;
        return false;
    }

}
