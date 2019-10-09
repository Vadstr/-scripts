using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoov : MonoBehaviour
{
	public GameObject Player;
    public Vector2 Vect;
	const int speed = 5;

    private void Start()
	{
        Vect.x = PlayerPrefs.GetFloat("VectX");
        Vect.y = PlayerPrefs.GetFloat("VectY");
        Application.targetFrameRate = 60;
        transform.position = Vect;
        if ((Vect.x <= -10 || Vect.x >= 0) && (Vect.y <= -2 || Vect.y >= 5))
        {
            Vect = new Vector2(-9.53f, -1.22f);
        }
    }

    private void Update()
    { 

        if (Vect.x==0.0f){
            Vect.x = -9.53f;
            Vect.y = -1.22f;

        }
        Vect.x = transform.position.x;
        PlayerPrefs.SetFloat("VectX",Vect.x);
        PlayerPrefs.Save();
        Vect.y = transform.position.y;
        PlayerPrefs.SetFloat("VectY", Vect.y);
        PlayerPrefs.Save();
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                Player.transform.Translate(Vector2.up * speed * Time.deltaTime);
            }



            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                Player.transform.Translate(Vector2.down * speed * Time.deltaTime);
            }



        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            Player.GetComponent<Animator>().SetTrigger("updown");
        }
        else {
            Player.GetComponent<Animator>().SetTrigger("NupNdown");
        }




            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Player.transform.Translate(Vector2.left * speed * Time.deltaTime);
            Player.GetComponent<Animator>().SetTrigger("left");
        }
        else{
                Player.GetComponent<Animator>().SetTrigger("Nleft");
            }






            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Player.transform.Translate(Vector2.right * speed * Time.deltaTime);
            Player.GetComponent<Animator>().SetTrigger("right");
        }
        else{
                Player.GetComponent<Animator>().SetTrigger("Nright");
            }


        

    }
}

