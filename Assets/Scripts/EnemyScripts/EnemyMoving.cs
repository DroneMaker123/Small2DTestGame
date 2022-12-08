using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    private EnemyInput enemyInput;
    [SerializeField] float movingSpeed = 3f;

    private bool canMove = true;

    void Start()
    {
        enemyInput = GetComponent<EnemyInput>();

        var verticalSize = Camera.main.orthographicSize * 2.0;

    }

    void Update()
    {
        if(canMove) transform.position += new Vector3(enemyInput.Horizontal, enemyInput.Vertical) * movingSpeed * Time.deltaTime;

    }

    public void setCanMove (bool state)
    {
        canMove = state;
    }
}
