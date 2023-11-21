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
        talkData.Add(10 + 1000, new string[] { "장미: 저기 뒤쪽에 새싹 보이지? ", "rose:저게 자라서 커다란 바오밥나무가 되면 ,이 별은 산산조각 날지도 몰라. 얼른 뽑아줘.", "어린왕자: 그렇지만 아직 어떤 새싹인지도 모르잖아, 조금만...",
        "장미: 됐으니까 빨리 뽑기나 해!","어린왕자: 하아, 알겠어..","바오밥 나무를 제거하자"});
    
        talkData.Add(11 + 2000, new string[] { "바오밥 나무를 제거한다","장미꽃에게 돌아가자" });

        talkData.Add(20 + 1000, new string[] { "어린왕자: 네가 말한 대로 새싹을 뽑았어. 그런데...", "어린왕자: 난 이제 다른 곳으로 떠날 때가 된 것 같아. 잘 있어." , "장미: ...",
        "어린왕자: ...잘 지내.","장미: 그렇게 우물쭈물하지 마, 신경질 나게. 떠나려면 빨리 떠나."});
        talkData.Add(21 + 3000, new string[] { "다른 행성으로 이동한다"});

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
