using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneInputManager : MonoBehaviour
{
    [SerializeField] List<GameObject> ButtonList;
    [SerializeField] LevelManager levelManager;
    [SerializeField] List<string> ButtonSceneNames;

    int cursorIndex = 0;
    
    [SerializeField] GameObject cursorObject;

    void Start()
    {

    }

    private void Update()
    {
        
        if (ButtonList.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                cursorIndex++;
                if (cursorIndex > ButtonList.Count - 1)
                {
                    cursorIndex = ButtonList.Count - 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                cursorIndex--;
                if (cursorIndex < 0)
                {
                    cursorIndex = 0;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(ButtonSceneNames[cursorIndex] == "Exit")
                {
                    Application.Quit();
                }
                else SceneManager.LoadScene(ButtonSceneNames[cursorIndex]);
            }
        }

        cursorObject.transform.position = new Vector3(-1, -cursorIndex * 0.5f + 0.5f);

    }



}
