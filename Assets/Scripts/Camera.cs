using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement _playerMovement;
   
    [SerializeField]
    private Vector3 _offset;
    private void Update()
    {
        transform.position = _playerMovement.transform.position + _offset;
    }
}
