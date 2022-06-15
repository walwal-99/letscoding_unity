using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float PlayerMoveSpeed = 5.0f;
    public float PlayerJumpPower = 5.0f;
    public int jumpCount = 2;
    public float gravityPower = 0.0f;
    private Transform PlayerTransform = null;
    private Rigidbody PlayerRigidbody = null;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        PlayerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        commonmove();
        PlayerRigidbody.AddForce(Vector3.down * gravityPower);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();   
        }
    }
    private void commonmove()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * Time.deltaTime * PlayerMoveSpeed);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * Time.deltaTime * PlayerMoveSpeed);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void Jump() {
        if (jumpCount > 0)
        {
            Debug.Log("점프");
            PlayerRigidbody.velocity = Vector2.zero;  // 점프를 할때 현재 Player가 가지고 있는 물리적 에너지를 초기화 (기존의 힘X, 마찰 X)
            PlayerRigidbody.AddForce(new Vector3(0, 1, 0) * PlayerJumpPower, ForceMode.Impulse); //위방향으로 올라가게함
            jumpCount--;    //점프할때 마다 점프횟수 감소
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            jumpCount = 2; //Ground에 닿으면 점프횟수가 2로 초기화됨
        }
        
    }
}
