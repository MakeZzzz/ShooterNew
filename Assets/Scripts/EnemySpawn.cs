using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private EnemyBehaviour _enemy;
    
    public UnityEvent DecreaseEnemiesEvent;
    public int numberOfEnemies;
    
    private List<EnemyBehaviour> _Enemies = new List<EnemyBehaviour>();
    
    private void OnDestroy()
    {
        foreach (var enemy in _Enemies)
        {
            enemy.EnemyDiedEvent -= DecreaseEnemiesCount;
        }
    }
    public void Initialize(EnemyBehaviour enemyBehaviour)
    {
        _enemy = enemyBehaviour;
    }
    private void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            var enemy = Instantiate(_enemy);
            _Enemies.Add(enemy);
            enemy.transform.position = new Vector3(Random.Range(-20, 20), 0.01f, Random.Range(20, -20));
            enemy.EnemyDiedEvent += DecreaseEnemiesCount;
        }
    }
    
    public void DecreaseEnemiesCount()
    {
        numberOfEnemies--;
        DecreaseEnemiesEvent.Invoke();
    }
}
