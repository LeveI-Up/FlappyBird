using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public KeyCode jumpKey=KeyCode.Space;
    public float jumpSpeed;

    void Update()
    {
        Rigidbody2D r = GetComponent<Rigidbody2D>();
        if(Input.GetKeyDown(jumpKey)){
                r.velocity = new Vector2(r.velocity.x,jumpSpeed);
            }
    }
}
