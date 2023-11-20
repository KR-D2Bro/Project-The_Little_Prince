using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        talkData.Add(1000, new string[] { "어린왕자야, 큰일났어","바오밥 나무가 자란다면 별에 구멍이 날꺼야" });
        talkData.Add(100, new string[] { "무언가 위험해보인다." });

        //Quest
        talkData.Add(10 + 1000, new string[] { "rose:어린왕자야, 큰일났어", "rose:바오밥 나무가 자란다면 별에 구멍이 날꺼야", "rose:그전에 제거해야해" });
        talkData.Add(11 + 2000, new string[] { "바오밥 나무를 제거한다","장미꽃에게 돌아가자" });

        talkData.Add(20 + 1000, new string[] { "rose:다행이야 이제 한동안 안전하겠어", "어린왕자: 장미야 난 다른 행성으로 모험을 떠나려 해" });
        talkData.Add(21 + 3000, new string[] { "다른 행성으로 이동한다"});
    }
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
