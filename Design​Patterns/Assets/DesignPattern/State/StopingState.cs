using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopingState : State
{

    public StopingState(Player _player) : base(_player)
    {
        stateType = "StopingState";
    }
    public override void Enter()
    {
        AddTransition(new RightTransition(player));
        AddTransition(new LeftTransition(player));
        AddTransition(new UpTransition(player));
        AddTransition(new DownTransition(player));

        player.SetStopingMaterial();
        player.Speed = 10.0f;

    }
    public override State UpdateState()
    {
        player.GetInputMgr.handleInput();
        return ComputeTransition();
    }
    public override void Exit()
    {

    }

}