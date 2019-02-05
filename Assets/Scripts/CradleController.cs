using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CradleController : MonoBehaviour
{
    BoxCollider2D rectangleCollider;
    public float endHeight;
    public float velocity;
    float height;


    IEnumerator Move()
    {
        height = GetComponent<BoxCollider2D>().bounds.extents.y;

        if (transform.position.y < endHeight-(height*1.5))  // moves the gameObject until the specified endHeight 
        {
            transform.Translate(0, velocity, 0);   //translates along Y each update by velocity 
            yield return new WaitForSeconds(.2f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, endHeight-height, 0);
            yield return 0;
        }
    }
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine("Move");
    }
  
}