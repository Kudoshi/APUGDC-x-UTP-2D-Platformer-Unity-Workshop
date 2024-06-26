using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpKillable : MonoBehaviour
{
    public Enemy enemy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            enemy.OnKilled();
        }
    }
}
