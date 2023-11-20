using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToNPC : MonoBehaviour
{
    
    public void Interact(RaycastHit hitInfo)
    {
        // NPC 레이어에 대한 처리 코드
        Debug.Log("Talk to NPC: " + hitInfo.transform.name);
    }
}
