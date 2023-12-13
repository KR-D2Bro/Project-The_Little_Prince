using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    private bool IsPause=false;
    public GameObject PauseMenu;
    public Button[] button;

    public AudioSource audio;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(IsPause){
                resume();
            }
            else{
                pause();
            }
        }
    }
    
    public void resume(){
        PauseMenu.SetActive(false);
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
        Time.timeScale=1f;
        IsPause=false;
        audio.Play();
    }

    public void pause(){
        PauseMenu.SetActive(true);
        Cursor.visible=true;
        Cursor.lockState=CursorLockMode.None;
        Time.timeScale=0f;
        audio.Pause();
        IsPause=true;
    }

    public void Quit(){
        Application.Quit();
    }
}
