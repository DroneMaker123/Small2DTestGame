using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private PlayerInput playerInput;
    [SerializeField] float movingSpeed = 5f;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        var verticalSize = Camera.main.orthographicSize * 2.0;

    }

    void Update()
    {
        transform.position += new Vector3(playerInput.Horizontal, playerInput.Vertical) * movingSpeed * Time.deltaTime;

        
    }
}
