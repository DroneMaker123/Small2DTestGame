using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 opposedToPlayerDirection = -(playerTransform.position - transform.position).normalized;
        Horizontal = opposedToPlayerDirection.x;
        Vertical = opposedToPlayerDirection.y;
    }
}
