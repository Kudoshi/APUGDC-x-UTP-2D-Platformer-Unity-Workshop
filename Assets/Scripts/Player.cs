using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MainUI MainUI;

    private int m_Gem;
    private Vector2 m_SpawnPos;
    private PlayerMovement m_PlayerMovement;
    private Rigidbody2D m_Rb;

    private void Start()
    {
        SetRespawnPoint(transform.position);
        m_PlayerMovement = GetComponent<PlayerMovement>();
        m_Rb = GetComponent<Rigidbody2D>();
    }

    public void AddGem(int gem)
    {
        m_Gem += gem;
        Debug.Log("Gem Count: " + m_Gem);

        MainUI.UpdateGemCounter(m_Gem);
    }

    public void KillPlayer()
    {
        transform.position = m_SpawnPos;
    }

    public void WinGame()
    {
        m_PlayerMovement.enabled = false;
        m_Rb.velocity = Vector2.zero;
        MainUI.TriggerWinCanvas(m_Gem);
    }

    public void SetRespawnPoint(Vector2 spawnPoint)
    {
        m_SpawnPos = spawnPoint;
    }
}
