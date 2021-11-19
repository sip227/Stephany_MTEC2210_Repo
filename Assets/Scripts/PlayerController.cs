using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMul = 1f;
    public float jumpY = 1f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float speed = Time.deltaTime * speedMul * xPos;

        rb.AddForce(Vector2.right * speed, ForceMode2D.Force);

        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(Vector2.up *jumpY, ForceMode2D.Force);
        }
    }
}
