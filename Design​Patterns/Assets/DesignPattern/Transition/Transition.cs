using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition
{
    protected State nextState;
    public State NextState
    {
        get { return nextState; }
    }

    public void InitState(State State)
    {
        nextState = State;
    }

    public virtual bool ComputeCondition() { return true; }
}
