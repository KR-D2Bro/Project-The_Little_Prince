using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements.Experimental;

public class QuestData
{
    public string questName;
    public int[] npcId;

    public QuestData(string name, int[] npc)
    {
        questName = name;
        npcId = npc;
    }
}
