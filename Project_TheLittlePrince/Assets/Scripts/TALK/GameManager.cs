using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject; // �÷��̾ ��ĵ�� ��
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
            isAction = true;  //�׼��� ����̸�         
            // hitInfo���� �ʿ��� ���� ����
            GameObject hitObject = hitInfo.collider.gameObject;

            // scanObject�� �Ҵ�
            scanObject = hitObject;
            objData objData = scanObject.GetComponent<objData>();
            Talk(objData.id, objData.isNpc);

        }
        talkPanel.SetActive(isAction); //â�� ����

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