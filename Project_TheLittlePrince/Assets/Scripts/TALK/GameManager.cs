﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject; // 플레이어가 스캔한 것
    public bool isAction;
    public int talkIndex;
    public void Action(RaycastHit hitInfo)
    {
           
            // hitInfo에서 필요한 정보 추출
        GameObject hitObject = hitInfo.collider.gameObject;

            // scanObject에 할당
        scanObject = hitObject;
        objData objData = scanObject.GetComponent<objData>();
        Talk(objData.id, objData.isNpc);
        talkPanel.SetActive(isAction); //창을 띄우고

    }

    void Talk(int id, bool isNpc)
    {
        int questTalkIndex = questManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id+ questTalkIndex, talkIndex);  //퀘스트 번호 + NPC id 퀘스트 대화 데이터
        if (talkData == null) {
            isAction = false; //대화가 끝나면 액션을 비활성화 하고 대화 순서을 0로 만들어 오류가 안나게
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            return;
        }
        if (isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;// 초상화를 위해 나눔 npc인 경우와 아닌 경우
        }
        isAction = true;
        talkIndex++;
    }


}