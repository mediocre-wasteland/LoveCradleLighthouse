using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CradleController : MonoBehaviour
{
    BoxCollider2D rectangleCollider;
    public float endHeight;
    public float velocity;
    IEnumerator Move()
    {
        if (transform.position.y <= endHeight)  // moves the gameObject until the specified endHeight 
        {
            transform.Translate(0, velocity, 0); //translates along Y each update by velocity 
            yield return new WaitForSeconds(.2f);
        }
    }
    // Use this for initialization
    void Start ()
    {
        rectangleCollider = GetComponent<BoxCollider2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine("Move");
    }
  
}