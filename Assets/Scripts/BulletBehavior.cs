using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private const string ENEMY_TAG = "Enemy";
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(ENEMY_TAG))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
 