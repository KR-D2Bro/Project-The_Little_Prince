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
        talkData.Add(1000, new string[] { "����ھ�, ū�ϳ���","�ٿ��� ������ �ڶ��ٸ� ���� ������ ������" });
        talkData.Add(100, new string[] { "���� �����غ��δ�." });

        //Quest
        talkData.Add(10 + 1000, new string[] { "����ھ�, ū�ϳ���","�ٿ��� ������ �ڶ��ٸ� ���� ������ ������","������ �����ؾ���" });
        talkData.Add(11 + 100, new string[] { "�ٿ��� ������ �����Ѵ�" });
    }
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
