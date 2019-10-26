using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoov : MonoBehaviour
{
	public GameObject Player;
    public Vector2 Vect;
	const int speed = 5;


    private void Start()
	{
        loadPosition();
        Application.targetFrameRate = 60;
        
    }

    private void Update()
    {

         if (Input.GetKeyDown(KeyCode.R))
            savePosition();

        if (Input.GetKeyDown(KeyCode.L))
        {
            loadPosition();

        }
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
            else
        {
                Player.GetComponent<Animator>().SetTrigger("Nright");
            }


        

    }
    public void savePosition()
    {

        Transform CurrentPlayerPosition = this.gameObject.transform;

        PlayerPrefs.SetFloat("PosX", CurrentPlayerPosition.position.x);
        PlayerPrefs.SetFloat("PosY", CurrentPlayerPosition.position.y);
    }

    public void loadPosition()
    {

        Transform CurrentPlayerPosition = this.gameObject.transform;

        Vector2 PlayerPosition = new Vector2(PlayerPrefs.GetFloat("PosX"),
                    PlayerPrefs.GetFloat("PosY"));

        CurrentPlayerPosition.position = PlayerPosition;
    }
    
    public string Playertag;


    private void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.tag == Playertag)
        {
            if (Input.GetKey(KeyCode.E))
            {
                savePosition();
                

            }
        }
    }
}

