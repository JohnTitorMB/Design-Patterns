using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class State
{

    protected string stateType = "Root";
    public string StateType { get { return StateType; } }
    protected Player player;
    protected List<Transition> m_listTransition;
    public State(Player _player)
    {
        player = _player;
        m_listTransition = new List<Transition>();
    }

   public void AddTransition(Transition transition)
    {
        m_listTransition.Add(transition);
    }
    public State ComputeTransition()
    {
        for(int i=0; i < m_listTransition.Count; i++)
        {
            if (m_listTransition[i].ComputeCondition())
            {
                m_listTransition[i].NextState.Enter();
                return m_listTransition[i].NextState;
            }
        }
        return this;
    }


    public virtual void Enter() { }
    public abstract State UpdateState();
    public virtual void Exit() { }

}
