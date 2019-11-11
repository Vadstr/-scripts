using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMoveFon : MonoBehaviour
{
    public GameObject bebe;
    public float speed;
    private void Start()
    {
        speed = Random.Range(2.5f, 4.5f);
        if (transform.position.x == -15)
        {
            speed = -speed;
        }
    }
    void FixedUpdate()
    { 
        bebe.transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -15)
        {
            Destroy(bebe);
        }
        if (transform.position.x > 15)
        {
            Destroy(bebe);
        }
    }
}
