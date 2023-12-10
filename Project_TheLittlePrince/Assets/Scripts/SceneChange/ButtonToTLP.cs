using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToTLP : MonoBehaviour
{
    public void ChangeScene(){
        SceneManager.LoadScene("Start to TLP Loading");
    }
}
