using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected float m_time;
    public float GetTime { get { return m_time; } set { m_time = value; } }

    protected string name = "";
    public string Name { get { return name; } set { name = value; } }
    public abstract void execute(); 
}
