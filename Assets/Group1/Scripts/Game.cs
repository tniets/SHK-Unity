using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _endScreen;

    private List<Enemy> _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>().ToList();

        foreach (Enemy enemy in _enemies)
        {
            enemy.Dying += OnEnemyDying;
        }
    }

    private void OnDisable()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.Dying -= OnEnemyDying;
        }
    }

    public void End()
    {
        _endScreen.SetActive(true);
    }

    private void OnEnemyDying(Enemy enemy)
    {
        enemy.Dying -= OnEnemyDying;

        _enemies.Remove(enemy);

        if (_enemies.Count == 0)
            End();
    }
}
