using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //private variables
    private Vector3 camMove = new Vector3(0, 5, -1);
    private Rigidbody2D rb;
    //public variables
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + camMove;
    }
}
