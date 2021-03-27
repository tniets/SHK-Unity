using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public event Action<Enemy> Dying = delegate { };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
            Die();
    }

    private void Die()
    {
        Dying(this);
        Destroy(gameObject);
    }
}
