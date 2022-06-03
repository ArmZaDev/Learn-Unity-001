using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                //หยุดเวลา
                Time.timeScale = 0;
                pauseUI.SetActive(true);  
            }
            else
            {
                //เล่นเกมต่อ
                Time.timeScale = 1;
                pauseUI.SetActive(false);  
            }
        }
    }
}
