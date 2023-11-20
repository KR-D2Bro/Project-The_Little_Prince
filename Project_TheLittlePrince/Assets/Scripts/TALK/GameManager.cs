using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject; // 플레이어가 스캔한 것
    public bool isAction;
    public int talkIndex;
    public void Action(RaycastHit hitInfo)
    {
        if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;  //액션이 사실이면         
            // hitInfo에서 필요한 정보 추출
            GameObject hitObject = hitInfo.collider.gameObject;

            // scanObject에 할당
            scanObject = hitObject;
            objData objData = scanObject.GetComponent<objData>();
            Talk(objData.id, objData.isNpc);

        }
        talkPanel.SetActive(isAction); //창을 띄우고

    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;
        }
    }


}