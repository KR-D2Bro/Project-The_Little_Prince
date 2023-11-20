using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterPortal : MonoBehaviour
{

    //포탈 오브젝트의 이름을 Scene 이름으로 설정
    //오브젝트의 이름을 받아서 해당 scene으로 이동
    
    public void Interact(RaycastHit hitInfo)
    {
        // Portal 레이어에 대한 처리 코드
        //Debug.Log("Entering Portal: " + hitInfo.transform.name);

        // 상호작용하는 물체의 이름을 사용하여 Scene으로 전환
        SceneManager.LoadScene(hitInfo.transform.name);    
    }
}