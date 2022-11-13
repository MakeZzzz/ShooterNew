using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Object = UnityEngine.Object;

public class EnemiesUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private EnemySpawn _enemyCounter;
    
    private Stack<Image> _images = new Stack<Image>();

    public void Initialize(EnemySpawn enemyCounter)
    {
        _enemyCounter = enemyCounter;
    }
    private void Start()
    {
        var counter = _enemyCounter.numberOfEnemies;
        for (int i = 0; i < counter; i++)
        {
            var image = Instantiate(_image, transform);
            _images.Push(image);
        }
    }
    
    [UsedImplicitly]
    public void DestroyImage()
    {
        Destroy(_images.Pop());
    }
    
}
