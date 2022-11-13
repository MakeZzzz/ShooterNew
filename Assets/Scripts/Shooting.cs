using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private float _bulletVelocity;
    
    public float ammunition;
    public UnityEvent<float> ShotEvent;
    
    private BulletBehavior _bullet;
    
    public void Initialize(BulletBehavior bullet)
    {
        _bullet = bullet;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammunition <= 0)
            {
                return;
            }
            
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
            ShotEvent.Invoke(1);
        }
    }
}
