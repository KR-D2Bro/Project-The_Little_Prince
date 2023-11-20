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
        questList.Add(10, new QuestData("ù ��ȭ"
            , new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("�ٸ� �༺���� �̵��ϱ�"
            , new int[] { 1000, 3000 }));
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
        ControlObjcet();
        if(id == questList[questId].npcId[questActionIndex])
        questActionIndex++;

        if(questActionIndex == questList[questId].npcId.Length) //����Ʈ ������ ���� ����Ʈ��
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
                break;
            case 20:
                break;
        }
    }
}
