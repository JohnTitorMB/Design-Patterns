using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DashTransition : Transition
{
    Player player;
    public DashTransition(Player _player)
    {
        player = _player;
        nextState = new DashState(_player);
    }

    public override bool ComputeCondition()
    {
        if (player.GetInputMgr.Commands.Count != 0)
        {
            if (player.GetInputMgr.Commands[0].Name == "DashCommand")
                return true;
        }

        return false;
    }
}