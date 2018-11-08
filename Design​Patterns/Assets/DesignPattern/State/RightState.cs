using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RightState : State
{
    public RightState(Player _player) : base(_player)
    {
        stateType = "RightState";

    }
    public override void Enter()
    {
        AddTransition(new DashTransition(player));
        AddTransition(new LeftTransition(player));
        AddTransition(new UpTransition(player));
        AddTransition(new DownTransition(player));

        AddTransition(new StopTransition(player));
        player.SetRightMaterial();
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