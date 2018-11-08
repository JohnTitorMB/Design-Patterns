using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpState : State
{
    public UpState(Player _player) : base(_player)
    {
        stateType = "UpState";
    }

    public override void Enter()
    {
        AddTransition(new DashTransition(player));
        AddTransition(new DownTransition(player));
        AddTransition(new RightTransition(player));
        AddTransition(new LeftTransition(player));
        AddTransition(new StopTransition(player));
        player.SetUpMaterial();
        player.Distance = 1.0f;
        player.Speed = 5.0f;

    }

    public override State UpdateState()
    {
        player.GetInputMgr.handleInput();
        player.GetInputMgr.ExecuteComande();
        return ComputeTransition();
    }

}
