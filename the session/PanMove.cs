using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanMove : MonoBehaviour
{
    public GameObject Pan;
    public int speed = 5;
    


    public void Start()
    {
        
        
    }

    
    public void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Pan.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Pan.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }


    }

    
    
}
