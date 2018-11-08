using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownState : State
{
    public DownState(Player _player) : base(_player)
    {
        stateType = "DownState";
    }
    // Use this for initialization
    public override void Enter()
    {
        AddTransition(new DashTransition(player));
        AddTransition(new RightTransition(player));
        AddTransition(new LeftTransition(player));
        AddTransition(new UpTransition(player));

        AddTransition(new StopTransition(player));
        player.SetDownMaterial();
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