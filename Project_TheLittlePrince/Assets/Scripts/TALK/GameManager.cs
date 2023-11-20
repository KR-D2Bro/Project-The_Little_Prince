using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject; // �÷��̾ ��ĵ�� ��
    public bool isAction;
    public int talkIndex;
    public void Action(RaycastHit hitInfo)
    {
           
            // hitInfo���� �ʿ��� ���� ����
        GameObject hitObject = hitInfo.collider.gameObject;

            // scanObject�� �Ҵ�
        scanObject = hitObject;
        objData objData = scanObject.GetComponent<objData>();
        Talk(objData.id, objData.isNpc);
        talkPanel.SetActive(isAction); //â�� ����

    }

    void Talk(int id, bool isNpc)
    {
        int questTalkIndex = questManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id+ questTalkIndex, talkIndex);  //����Ʈ ��ȣ + NPC id ����Ʈ ��ȭ ������
        if (talkData == null) {
            isAction = false; //��ȭ�� ������ �׼��� ��Ȱ��ȭ �ϰ� ��ȭ ������ 0�� ����� ������ �ȳ���
            talkIndex = 0;
            return;
        }
        if (isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;// �ʻ�ȭ�� ���� ���� npc�� ���� �ƴ� ���
        }
        isAction = true;
        talkIndex++;
    }


}