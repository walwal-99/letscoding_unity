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
            Debug.Log("����");
            PlayerRigidbody.velocity = Vector2.zero;  // ������ �Ҷ� ���� Player�� ������ �ִ� ������ �������� �ʱ�ȭ (������ ��X, ���� X)
            PlayerRigidbody.AddForce(new Vector3(0, 1, 0) * PlayerJumpPower, ForceMode.Impulse); //���������� �ö󰡰���
            jumpCount--;    //�����Ҷ� ���� ����Ƚ�� ����
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            jumpCount = 2; //Ground�� ������ ����Ƚ���� 2�� �ʱ�ȭ��
        }
        
    }
}
