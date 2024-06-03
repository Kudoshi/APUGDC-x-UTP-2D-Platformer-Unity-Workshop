using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int m_Gem;
    private Vector2 m_SpawnPos;
    private void Start()
    {
        m_SpawnPos = transform.position;
    }

    public void AddGem(int gem)
    {
        m_Gem += gem;
        Debug.Log("Gem Count: " + m_Gem);
    }

    public void KillPlayer()
    {
        transform.position = m_SpawnPos;
    }
}
