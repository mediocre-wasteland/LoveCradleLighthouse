using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementspeed;
    public float detectionDistance;
    public bool isMovingRight = true;
    public Transform voidDetection;


    void Update()
    {
        transform.Translate(Vector2.right * movementspeed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(voidDetection.position, Vector2.down, detectionDistance);
        if (groundInfo.collider == false)
        {
            if (isMovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                isMovingRight = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isMovingRight = true;
            }
        }
    }

}

