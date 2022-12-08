using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitToMainScene : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.FindObjectOfType<LevelManager>().GetComponent<LevelManager>().LoadMainMenu();
        }
    }
}
