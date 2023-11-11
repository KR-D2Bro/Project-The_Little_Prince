using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text talkeText;
    public GameObject scanObject; //플레이어가 스캔한것
    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        talkeText.text = scanObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
