using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private float h, v;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        if(transform.position.y >= 0)
        {
            transform.position = 
                new Vector2(transform.position.x, 0);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(
            rb.position + new Vector2(h,v) * speed * Time.deltaTime
            );
    }
}
