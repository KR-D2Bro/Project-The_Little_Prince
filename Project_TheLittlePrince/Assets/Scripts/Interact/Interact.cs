using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Interact : MonoBehaviour
{
    public GameManager manager;
    public float interactionDistance = 2.0f;
    [SerializeField] private LayerMask layerMask;

    private InteractWithObject interactWithObject;
    private TalkToNPC talkToNPC;
    private EnterPortal enterPortal;

    private void Start()
    {
        /*
        // 해당 기능을 담당하는 클래스 인스턴스 생성
        interactWithObject = new InteractWithObject();
        talkToNPC = new TalkToNPC();
        enterPortal = new EnterPortal();
        */

        interactWithObject = gameObject.AddComponent<InteractWithObject>();
        talkToNPC = gameObject.AddComponent<TalkToNPC>();
        enterPortal = gameObject.AddComponent<EnterPortal>();
    }
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
      RaycastHit hitInfo;
      Vector3 rayStart = this.transform.position - new Vector3(0f, 1f, 0f);

      // 시각적으로 레이를 표시 (레이가 충돌하지 않을 때 red)
      //Debug.DrawRay(rayStart, transform.forward * interactionDistance, Color.red, 2.0f);

      if(Physics.Raycast(rayStart, this.transform.forward, out hitInfo, interactionDistance, layerMask))
      {
        int hitLayer = hitInfo.transform.gameObject.layer;
        string layerName = LayerMask.LayerToName(hitLayer);

        // 시각적으로 레이를 표시 (레이가 충돌할 때 green)
        //Debug.DrawRay(rayStart, transform.forward * interactionDistance, Color.green, 2.0f);

        switch (layerName)
        {
            case "Object":
                interactWithObject.Interact(hitInfo);
                manager.Action(hitInfo); // Action 메서드 호출 추가
                break;
            case "NPC":
                talkToNPC.Interact(hitInfo);
                manager.Action(hitInfo); // Action 메서드 호출 추가
                break;
            case "Portal":
                enterPortal.Interact(hitInfo);
                manager.Action(hitInfo);
                break;
            default:
                Debug.Log("Unhandled layer: " + layerName);
                break;
        }
      }

    }

}