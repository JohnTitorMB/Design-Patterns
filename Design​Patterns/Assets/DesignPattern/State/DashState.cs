using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DashState : State
{
    public DashState(Player _player) : base(_player)
    {
        stateType = "DashState";
    }
    // Use this for initialization
    public override void Enter()
    {
        AddTransition(new RightTransition(player));
        AddTransition(new LeftTransition(player));
        AddTransition(new UpTransition(player));
        AddTransition(new DownTransition(player));

        AddTransition(new StopTransition(player));
        player.SetDashMaterial();
        player.Distance = 5.0f;
        player.Speed = 10.0f;

    }
    public override State UpdateState()
    {
        player.GetInputMgr.handleInput();
        player.GetInputMgr.ExecuteComande();
        return ComputeTransition();
    }

}
