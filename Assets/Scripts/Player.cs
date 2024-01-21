using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoving : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;
    public Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized * moveSpeed;

        rb2d.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }
}