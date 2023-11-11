using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    //행성의 위치와 방향을 나타냅니다.
    public Transform planet;  
    
    //게임 오브젝트를 행성의 표면에 정렬할 지 여부를 나타냅니다.
    public bool alignToPlanet = true;

    //중력 상수를 나타냅니다.
    float gravityConstant = 9.8f;
    
    //게임 오브젝트에 물리적인 작업을 수행할 변수입니다.
    Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>(); //'Rigidbody r' 변수를 초기화합니다.
    }

    //중력과 게임 오브젝트의 방향 정렬을 처리하는 함수입니다.
    void FixedUpdate()
    {
        // 'toCenter' 변수는 현재 게임 오브젝트에서 행성까지의 벡터를 나타냅니다.
        Vector3 toCenter = planet.position - transform.position;
        toCenter.Normalize(); // 'toCenter' 벡터를 정규화합니다.

        // 'toCenter' 벡터에 중력 상수를 곱한 힘을 게임 오브젝트에 추가합니다. 
        // 'ForceMode.Acceleration'은 힘을 질량에 대한 가속도로 적용함을 의미합니다.
        r.AddForce(toCenter * gravityConstant, ForceMode.Acceleration);

        if (alignToPlanet)
        {
            //현재 방향에서 행성의 방향으로 회전하는 쿼터니언을 계산합니다.
            Quaternion q = Quaternion.FromToRotation(transform.up, -toCenter) * transform.rotation;
            // 'Quaternion.Slerp' 함수를 사용해 부드럽게 회전합니다.
            transform.rotation = Quaternion.Slerp(transform.rotation, q, 1);
            //Quaternion q = Quaternion.FromToRotation(transform.up, -toCenter);
            //q = q * transform.rotation;
            //transform.rotation = Quaternion.Slerp(transform.rotation, q, 1);
        }
    }
}