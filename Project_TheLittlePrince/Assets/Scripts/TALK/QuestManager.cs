using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    Dictionary<int, QuestData> questList; //퀘스트 데이터 저장
    public int questActionIndex;//generateData의 new int[]의 값을 가져오기 위한 부가적 인덱스
    public GameObject[] questObject;

    public int questId; //지금 진행중인 id 이건 딕셔널리에 들어간거임
    void Awake()
    {
        questList = new Dictionary<int, QuestData>(); //초기화
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        questList.Add(10, new QuestData("첫 대화"
            , new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("다른 행성으로 이동하기"
            , new int[] { 1000, 3000 }));
        questList.Add(30, new QuestData("오만한 왕과 대화하기"
            , new int[] { 1000, 3000 }));
        questList.Add(40, new QuestData("주정뱅이와 대화하기"
            , new int[] { 1000, 3000 }));
    }

    public int GetQuestTalkIndex(int id) //npc id
    {
        return questId + questActionIndex; //게임 메니저에 내보냄

    }
    public string CheckQuest(int id)
    {
        ControlObjcet();
        if(id == questList[questId].npcId[questActionIndex])
        questActionIndex++;

        if(questActionIndex == questList[questId].npcId.Length) //퀘스트 다했음 다음 퀘스트로
            NextQuset();
        return questList[questId].questName;
    }

    void NextQuset()
    {
        questId += 10;
        questActionIndex = 0; //새로운 퀘스트가 시작했기에
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
