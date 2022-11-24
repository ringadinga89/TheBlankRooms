using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndRun : MonoBehaviour
{
    float speed, moveX, moveY;
    [SerializeField] float normalSpeed, runSpeed;
    

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;
        else
            speed = normalSpeed;

        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(moveX, moveY, 0);
    }
}
