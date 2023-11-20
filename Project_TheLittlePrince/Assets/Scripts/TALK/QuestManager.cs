using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    Dictionary<int, QuestData> questList; //����Ʈ ������ ����
    public int questActionIndex;//generateData�� new int[]�� ���� �������� ���� �ΰ��� �ε���

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
            , new int[] { 1000, 100 }));
    }

    public int GetQuestTalkIndex(int id) //npc id
    {
        return questId + questActionIndex; //���� �޴����� ������

    }
    public void CheckQuest()
    {
        questActionIndex++;
    }
}
