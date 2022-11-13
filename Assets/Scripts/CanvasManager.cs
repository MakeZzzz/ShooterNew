using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private EnemiesUI _enemyIcons;
    [SerializeField] private BulletsUI _bulletsUI;
    [SerializeField] private Shooting _shooting;
    [SerializeField] private EnemySpawn _enemySpawn;

    private void Awake()
    {
        _bulletsUI.Initialize(_shooting);
        _enemyIcons.Initialize(_enemySpawn);
    }
}

