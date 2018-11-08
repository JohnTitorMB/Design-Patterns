using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    List<Command> m_commands;
    Player player;
    float m_time = 0;
    public List<Command> Commands { get { return m_commands; } }

    public InputManager(Player _player)
    {
        m_commands = new List<Command>();
        player = _player;
    }

    public void AddCommande(Command command)
    {
        m_commands.Add(command);
    }

    public void NextCommande()
    {
        m_commands.Remove(m_commands[0]);
    }

    public void handleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (m_commands.Count != 0 && m_commands[m_commands.Count - 1].Name == "UpCommand")
            {
                if (m_time - m_commands[m_commands.Count - 1].GetTime <= 0.25f)
                    m_commands[m_commands.Count - 1].Name = "DashCommand";
                else
                    AddCommande(new UpCommand(player, m_time));
            }
            else
                AddCommande(new UpCommand(player, m_time));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (m_commands.Count != 0 && m_commands[m_commands.Count - 1].Name == "DownCommand")
            {
                if (m_time - m_commands[m_commands.Count - 1].GetTime <= 0.25f)
                    m_commands[m_commands.Count - 1].Name = "DashCommand";
                else
                    AddCommande(new DownCommand(player, m_time));
            }
            else
                AddCommande(new DownCommand(player, m_time));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (m_commands.Count != 0 && m_commands[m_commands.Count - 1].Name == "RightCommand")
            {
                if (m_time - m_commands[m_commands.Count - 1].GetTime <= 0.25f)
                    m_commands[m_commands.Count - 1].Name = "DashCommand";
                else
                    AddCommande(new RightCommand(player, m_time));
            }
            else
                AddCommande(new RightCommand(player, m_time));

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (m_commands.Count != 0 && m_commands[m_commands.Count - 1].Name == "LeftCommand")
            {
                if (m_time - m_commands[m_commands.Count - 1].GetTime <= 0.25f)
                    m_commands[m_commands.Count - 1].Name = "DashCommand";
                else
                    AddCommande(new LeftCommand(player, m_time));
            }
            else
                AddCommande(new LeftCommand(player, m_time));
        }
    }

   public void ExecuteComande()
    {
        m_commands[0].execute();
    }

    public void UpdateTime()
    {
        m_time = m_time + Time.deltaTime;
    }
}
