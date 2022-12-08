using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    private Rigidbody2D enemyRigidBody2D;
    private EnemyMoving enemyMoving;

    private void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        enemyMoving = GetComponent<EnemyMoving>();
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemyMoving.setCanMove(false);
        }
    }
}
