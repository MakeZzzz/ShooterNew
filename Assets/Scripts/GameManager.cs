using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Shooting _shooting;
    [SerializeField] private BulletBehavior _bulletBehavior;
    [SerializeField] private EnemyBehaviour _enemyBehaviour;
    [SerializeField] private EnemySpawn _enemySpawn;
    [SerializeField] private PlayerMovement _player;

    void Start()
    {
        _shooting.Initialize(_bulletBehavior);
        _enemySpawn.Initialize(_enemyBehaviour);
        _enemyBehaviour.Initialize(_player);
    }
}
