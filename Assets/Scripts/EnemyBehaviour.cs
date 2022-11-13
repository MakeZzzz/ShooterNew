using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Action EnemyDiedEvent;
    
    [SerializeField] private float travelTime = 6000f;
    private PlayerMovement _player;
    private float _currentTime;
   
    [UsedImplicitly]
    public void Initialize(PlayerMovement player)
    {
        _player = player;     
    }
    
    private void Start()
    {
        _player = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        transform.LookAt(_player.transform.position);
        _currentTime += Time.deltaTime;
        var progress = _currentTime / travelTime ;
        transform.position = Vector3.Lerp(transform.position,  _player.transform.position, progress);
    }
    private void OnDestroy()
    {
        EnemyDiedEvent.Invoke();
    }
    
}
