using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CradleController : MonoBehaviour
{
    BoxCollider2D rectangleCollider;
    IEnumerator Move()
    {
        for (float T = 4f; T >= 0; T -= 0.1f)
        {
            if (transform.position.y < 1f)
            {
                transform.Translate(0, 0.01f, 0);
                yield return new WaitForSeconds(.2f);
            }
              
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