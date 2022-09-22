using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private Animator playerAnim;
    private Rigidbody2D rb;
    //public variables
    public float moveHoriz;
    public float moveVert;
    public Vector2 moving;
    public float speed = 17;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHoriz = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");
        moving = new Vector2(moveHoriz, moveVert);
        if (moving.magnitude > 0.1)
            rb.velocity = moving * speed;
        else rb.velocity = Vector2.zero;
        if(moveHoriz < 0)
        {
            transform.localScale = new Vector3(-1f, 1, 1);
        }
        else transform.localScale = new Vector3(1f, 1, 1);
        if (moving.sqrMagnitude > 0.06f)
        {
            playerAnim.SetBool("isRun", true);
        }
        else playerAnim.SetBool("isRun", false);
    }
}
