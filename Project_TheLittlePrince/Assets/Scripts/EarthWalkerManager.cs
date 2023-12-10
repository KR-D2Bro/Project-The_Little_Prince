using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]

public class EarthWalkerController : MonoBehaviour
{
    // 플레이어의 이동 속도
    public float movementspeed = 5.0f;

    // 점프 가능 여부
    public bool canJump = true;

    // 점프 높이
    public float jumpHeight = 2.5f;

    // 플레이어 카메라
    public Camera playerCamera;

    // 카메라 회전 속도
    public float CameraSpeed = 2.0f;

    // 카메라 X 회전 한계
    public float CameraXLimit = 30.0f;

    bool grounded = false;

    //애니메이터
    Animator anim;

    //이동중인지 확인하는 불리안 변수
    public bool IsWalking = false;

    Rigidbody Player;

    Vector2 rotation = Vector2.zero;

    float VelocityChangeLimit = 10.0f;

    // 중력 상수
    float gravityConstant = 9.8f;

    void Awake()
    {
        // Animator 컴포넌트 가져오기
        anim = GetComponent<Animator>();

        // Rigidbody 컴포넌트 가져오기
        Player = GetComponent<Rigidbody>();

        // Rigidbody 설정 초기화
        Player.freezeRotation = true;
        Player.useGravity = false; // 중력은 여기서 끕니다.
        Player.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        // 초기 회전 값 설정
        rotation.y = transform.eulerAngles.y;

        // 커서 숨기고 고정
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        if (grounded)
        {
            // 플레이어 이동 속도 계산
            Vector3 forwardDir = Vector3.Cross(transform.up, -playerCamera.transform.right).normalized;
            Vector3 rightdirection = Vector3.Cross(transform.up, playerCamera.transform.forward).normalized;
            Vector3 targetVelocity = (forwardDir * Input.GetAxis("Vertical") + rightdirection * Input.GetAxis("Horizontal")) * movementspeed;

            // 현재 속도 및 변화량 계산
            Vector3 velocity = transform.InverseTransformDirection(Player.velocity);
            velocity.y = 0;
            velocity = transform.TransformDirection(velocity);
            Vector3 velocityChange = transform.InverseTransformDirection(targetVelocity - velocity);
            velocityChange.x = Mathf.Clamp(velocityChange.x, -VelocityChangeLimit, VelocityChangeLimit);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -VelocityChangeLimit, VelocityChangeLimit);
            velocityChange.y = 0;
            velocityChange = transform.TransformDirection(velocityChange);

            // 애니메이션
            if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D))
            {
                IsWalking = true;
                anim.SetBool("IsWalk", true);
            }
            else
            {
                IsWalking = false;
                anim.SetBool("IsWalk", false);
            }

            // 속도 변경 적용
            Player.AddForce(velocityChange, ForceMode.VelocityChange);

            // 점프 처리
            if (Input.GetButton("Jump") && canJump)
            {
                Player.AddForce(transform.up * jumpHeight, ForceMode.VelocityChange);
            }
        }

        // 중력 처리
        Vector3 gravity = Vector3.down * gravityConstant;
        Player.AddForce(gravity, ForceMode.Acceleration);

        grounded = false;

        // 카메라 및 플레이어 회전 입력 처리
        rotation.x += -Input.GetAxis("Mouse Y") * CameraSpeed;
        rotation.x = Mathf.Clamp(rotation.x, -CameraXLimit + 20, CameraXLimit + 20);
        playerCamera.transform.localRotation = Quaternion.Euler(rotation.x, 0, 0);
        Quaternion localRotation = Quaternion.Euler(0f, Input.GetAxis("Mouse X") * CameraSpeed, 0f);
        transform.rotation = transform.rotation * localRotation;
    }

    void OnCollisionStay()
    {
        // 플레이어가 바닥에 닿아 있는지 확인
        grounded = true;
    }
}
