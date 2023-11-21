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
        talkData.Add(1000, new string[] { "어린왕자야, 큰일났어", "바오밥 나무가 자란다면 별에 구멍이 날꺼야" });
        talkData.Add(100, new string[] { "무언가 위험해보인다." });

        //Quest
        talkData.Add(10 + 2000, new string[] { "바오밥 나무 싹을 제거한다.", "다른 싹을 찾아보자" });

        talkData.Add(11 + 2001, new string[] { "바오밥 나무 싹을 제거한다.", "다른 싹을 찾아보자" });
        talkData.Add(12 + 2002, new string[] { "바오밥 나무 싹을 제거한다.", "모든 싹을 제거 했다 이제 장미꽃을 찾아가자" });
        talkData.Add(13 + 1000, new string[] { "어린왕자: 와 너 너무 예쁘구나", "장미:안녕 어린왕자야 부탁하나만 들어줄래?", "장미:여기는 내가살기에 너무 추운것 같아 날 따뜻하게 해줄래?", "어린왕자: 알겠어", "유리병을 가져오자" });

        talkData.Add(20 + 2050, new string[] { "적당한 크기의 유리병이다.", "장미꽃에게 가져다 주자" });
        talkData.Add(21 + 1000, new string[] { "어린왕자: 여기 유리병이야", "장미:고마워.. 그런데 좀 더 빨리 해줄순 없었어?", "미안 다음엔 더 빨리해줄게....", "이제는 좀 더운것 같아.. 유리병 좀 치워줘" });
        talkData.Add(22 + 2060, new string[] { " 유리병을 치운다.", "박스에다가 가져다 주자" });
        talkData.Add(23 + 2070, new string[] { "박스 안에 집어넣는다.", "어린왕자: ...(예쁘지만 너무 까탈스럽네..)", "장미를 떠날때가 된것 같아","장미에게 행성을 떠난다고 하자" });
        talkData.Add(24 + 1000, new string[]{ "난 이제 다른 곳으로 떠날 때가 된 것 같아. 잘 있어." , "장미: ...","어린왕자: ...잘 지내.","장미: 그렇게 우물쭈물하지 마, 신경질 나게. 떠나려면 빨리 떠나.","포탈을 사용하여 떠나자"});
        talkData.Add(22 + 3000, new string[] { "다른 행성으로 이동한다"});

        talkData.Add(30 + 4000, new string[] { "왕: 아! 신하가 한 명 오는구나. 짐이 너를 더 잘 볼 수 있도록 가까이 오너라.", "어린왕자:저…좀 앉아도 될까요?",
            "왕: 그대에게 앉기를 명하노라.","왕: 만일 짐이 그대에게 물새로 변하라고 명령했는데 그대가 그것에 복종하지 않는다면,그것은 그대의 잘못인가, 짐의 잘못인가?","어린왕자: 그것은 전하의 잘못이죠.",
            "왕: 그렇다. 사람에게는 각자 그 사람이 할 수 있는 일을 시켜야 하는 법이다.","나는 이치에 맞는 명령만 내리기에, 모두에게 복종하라는 명령을 내릴 권리가 있다."});
        talkData.Add(31 + 4000, new string[] { "어린왕자: 이제 이곳에서는 할 일이 없으니 떠나도록 하겠습니다.","왕: 떠나지 말라. 가지 말라. 너를 대신으로 삼겠노라!",
            "어린왕자: (떠날 준비는 끝났지만… 늙은 왕의 마음을 지켜주고 싶어.)","제가 명령에 복종하게 하고 싶다면 이치에 맞는 명령을 내려주세요.","지금 나에게 맞는 명령은 '이 별을 떠나라'는 것이에요.",
        "왕: ...그대를 내 외교관으로 임명하노라." });
        talkData.Add(32 + 4000, new string[] { "가지마라...." });
        talkData.Add(31 + 3000, new string[] { "다른 행성으로 이동한다" });

        talkData.Add(40 + 4100, new string[] { "어린왕자: 아저씨 뭘 하고 있어요?","술꾼: 술 마시지.","어린왕자: 왜 마셔요?","술꾼: 잊기 위해서지.","어린왕자: 뭘 잊고 싶은데요?","술꾼: 부끄러움.",
            "어린왕자: 뭐가 부끄러우세요?","술꾼: 술을 마시고 있다는 게 부끄러워!","어린왕자:(어른들이란 정말이지…알 수가 없어)" });
        talkData.Add(41 + 4200, new string[] { "술병이다 가져다주자" ,"술병을 챙겼다."});
    }
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
