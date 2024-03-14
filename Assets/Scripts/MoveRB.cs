using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     [SerializeField] private float speed = 5f; // ความเร็วของการเคลื่อนไหว

     [SerializeField] private Rigidbody rb; // อ้างอิง Rigidbody ของ GameObject

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>(); // เข้าถึง Rigidbody ใน GameObject นี้
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // รับค่า input จากแป้นพิมพ์
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // กำหนดความเร็วของการเคลื่อนไหวให้กับ Rigidbody
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
    }

}
