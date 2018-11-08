using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RootState : State
{
    public RootState(Player _player) : base(_player)
    {
        stateType = "RootState";

    }
    public override void Enter()
    {
    }


    public override State UpdateState()
    {
        return ComputeTransition();
    }

}
