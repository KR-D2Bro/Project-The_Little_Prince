using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text talkeText;
    public GameObject scanObject; //�÷��̾ ��ĵ�Ѱ�
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
