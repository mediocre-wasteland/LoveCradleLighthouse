using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float horizSpeed = 0; // how fast the player can move left and right
    public float horizAcceleration = 0.001f; // how fast the player can reach top horizontal speed
    public float maxHorizSpeed = 0.01f; // max speed on the horizontal plane
    public float vertSpeed = 0; // how fast the player can ascend and descend 
    public float gravity = 0.05f; // how fast the player accelerates towards the ground
    public float maxVertSpeed = 0.5f; // max speed on the vertical plane
    public bool isOnGround; // whether or not the player is on the ground
    public bool hasDoubleJump; // whether or not the player has not jumped in mid air without touching the ground

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)) //checks if D is pressed while A is not
        {
            if (horizSpeed < maxHorizSpeed)
            {
                horizSpeed += horizAcceleration; //changes speed gradually to the max speed in the direction of right
            }
        }
        else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) //checks if A is pressed while D is not
        {
            if (horizSpeed > -maxHorizSpeed)
            {
                horizSpeed -= horizAcceleration; //changes speed gradually to the max speed in the direction of left
            }
        }
        else
        {
            horizSpeed = 0; // sets speed to 0 if no buttons are pressed
        }
        Vector3 movement = new Vector3(transform.position.x + horizSpeed, transform.position.y, transform.position.z);
        transform.SetPositionAndRotation(movement, transform.rotation); // applies transformation

    }
}
