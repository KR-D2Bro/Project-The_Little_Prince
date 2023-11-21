using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    Dictionary<int, QuestData> questList; //����Ʈ ������ ����
    public int questActionIndex;//generateData�� new int[]�� ���� �������� ���� �ΰ��� �ε���
    public GameObject[] questObject;

    public int questId; //���� �������� id �̰� ��ųθ��� ������
    void Awake()
    {
        questList = new Dictionary<int, QuestData>(); //�ʱ�ȭ
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        questList.Add(10, new QuestData("�ٿ��� ���� ���� �����Ѵ�."
            , new int[] { 2000, 2001 ,2002, 1000 }));
        questList.Add(20, new QuestData(" �������� �ٸ� �༺"
            , new int[] { 2050, 1000 ,2060,2070,1000}));
        questList.Add(30, new QuestData("������ �հ� ��ȭ�ϱ�"
            , new int[] { 1000, 3000 }));
        questList.Add(40, new QuestData("�������̿� ��ȭ�ϱ�"
            , new int[] { 1000, 3000 }));
    }

    public int GetQuestTalkIndex(int id) //npc id
    {
        return questId + questActionIndex; //���� �޴����� ������

    }
    public string CheckQuest(int id)
    {
        
        if(id == questList[questId].npcId[questActionIndex])
        questActionIndex++;

        ControlObjcet();

        if (questActionIndex == questList[questId].npcId.Length) //����Ʈ ������ ���� ����Ʈ��
            NextQuset();
        return questList[questId].questName;
    }

    void NextQuset()
    {
        questId += 10;
        questActionIndex = 0; //���ο� ����Ʈ�� �����߱⿡
    }

    void ControlObjcet()
    {
        switch (questId)
        {
            case 10:
                if (questActionIndex == 1)
                    questObject[0].SetActive(false);
                else if (questActionIndex == 2)
                    questObject[1].SetActive(false);
                else if (questActionIndex == 3)
                    questObject[2].SetActive(false);
                if (questActionIndex == 3)
                    questObject[3].SetActive(true);
                if (questActionIndex == 4)
                    questObject[4].SetActive(true);
                break;
            case 20:
                if (questActionIndex == 1)
                    questObject[4].SetActive(false);
                if (questActionIndex == 2)
                    questObject[5].SetActive(true);
                if (questActionIndex == 3)
                    questObject[5].SetActive(false);
                break;
        }
    }
}
