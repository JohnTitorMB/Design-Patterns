using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    Material[] m_materials;
    [SerializeField]
    float m_Speed;

    public float Speed { get { return m_Speed; } set { m_Speed = value; } }

    FiniteStateMachine m_finnishedState;
    InputManager m_inputManager;
    MeshRenderer m_meshRenderer;
    float m_distance = 1.0f;
    float displayActtualy = 0;
    public float Distance { get { return m_distance; } set { m_distance = value; } }

    public InputManager GetInputMgr { get { return m_inputManager; } }
    public float DisplayActtualy
    {
        get { return displayActtualy; }
    }



    // Use this for initialization
    void Start()
    {
        m_inputManager = new InputManager(this);
        m_finnishedState = new FiniteStateMachine(this);
        m_finnishedState.Init(new StopTransition(this));
        m_meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        m_inputManager.UpdateTime();
        m_finnishedState.Update();

    }

    public void DisplayRight()
    {
        Vector3 pos = transform.position;
        float displayTest = displayActtualy + m_Speed * Time.deltaTime;
        if (displayTest >= m_distance)
        {
            pos.x = pos.x + (m_distance - displayActtualy);
            displayActtualy = 0.0f;
            m_inputManager.NextCommande();
        }
        else
        {
            pos.x += m_Speed * Time.deltaTime;
            displayActtualy += m_Speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void DisplayLeft()
    {
        Vector3 pos = transform.position;
        float displayTest = displayActtualy + m_Speed * Time.deltaTime;
        if (displayTest >= m_distance)
        {
            pos.x = pos.x - (m_distance - displayActtualy);
            displayActtualy = 0.0f;
            m_inputManager.NextCommande();
        }
        else
        {
            pos.x -= m_Speed * Time.deltaTime;
            displayActtualy += m_Speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void DisplayUp()
    {
        Vector3 pos = transform.position;
        float displayTest = displayActtualy + m_Speed * Time.deltaTime;
        if (displayTest >= m_distance)
        {
            pos.z = pos.z + (m_distance - displayActtualy);
            displayActtualy = 0.0f;
            m_inputManager.NextCommande();
        }
        else
        {
            pos.z += m_Speed * Time.deltaTime;
            displayActtualy += m_Speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void DisplayDown()
    {
        Vector3 pos = transform.position;
        float displayTest = displayActtualy + m_Speed * Time.deltaTime;
        if (displayTest >= m_distance)
        {
            pos.z = pos.z - (m_distance - displayActtualy);
            displayActtualy = 0.0f;
            m_inputManager.NextCommande();
        }
        else
        {
            pos.z -= m_Speed * Time.deltaTime;
            displayActtualy += m_Speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void SetStopingMaterial()
    {
        m_meshRenderer.material = m_materials[0];
    }

    public void SetUpMaterial()
    {
        m_meshRenderer.material = m_materials[1];
    }

    public void SetDownMaterial()
    {
        m_meshRenderer.material = m_materials[2];
    }

    public void SetLeftMaterial()
    {
        m_meshRenderer.material = m_materials[3];
    }

    public void SetRightMaterial()
    {
        m_meshRenderer.material = m_materials[4];
    }

    public void SetDashMaterial()
    {
        m_meshRenderer.material = m_materials[5];
    }
}
