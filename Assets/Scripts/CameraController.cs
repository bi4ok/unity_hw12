using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - player.position;
    }

    private void FixedUpdate()
    {
        transform.position = player.position + _offset;
    }
}
