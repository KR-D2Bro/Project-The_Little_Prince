using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    Dictionary<int, QuestData> questList; //퀘스트 데이터 저장
    public int questActionIndex;//generateData의 new int[]의 값을 가져오기 위한 부가적 인덱스

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
            , new int[] { 1000, 100 }));
    }

    public int GetQuestTalkIndex(int id) //npc id
    {
        return questId + questActionIndex; //게임 메니저에 내보냄

    }
    public void CheckQuest()
    {
        questActionIndex++;
    }
}
