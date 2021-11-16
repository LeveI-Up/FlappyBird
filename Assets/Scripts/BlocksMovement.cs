using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksMovement : MonoBehaviour
{
   
        Vector3 movement;
        [SerializeField] float speed;
        GameObject destroy;

        void Start()
        {
            movement.x = speed;
            destroy = GameObject.Find("destroy");
        }

        // Update is called once per frame
        void Update()
        {
            platformMove();
        }

        void platformMove()
        {
            transform.position += movement * Time.deltaTime;
            if (transform.position.x <= destroy.transform.position.x)
            {
                Destroy(gameObject);
            }
        }
}
