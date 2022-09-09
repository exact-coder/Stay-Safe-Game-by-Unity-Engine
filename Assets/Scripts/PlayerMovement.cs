using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // used for going to top
        if(Input.GetKey(KeyCode.W) && gameObject.transform.position.y < 3.93){
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + playerSpeed * Time.deltaTime);
        }
        // used for going to bottom
        else if(Input.GetKey(KeyCode.S) && gameObject.transform.position.y > (-3.93)){
            gameObject.transform.position = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y - playerSpeed * Time.deltaTime);
        }
        // used for going to right
        else if(Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 6.45){
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + playerSpeed * Time.deltaTime,gameObject.transform.position.y);
        }
        // used for going to left
        else if(Input.GetKey(KeyCode.A)&& gameObject.transform.position.x > (-6.35)){
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - playerSpeed * Time.deltaTime,gameObject.transform.position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Enemy")
        {
            GameManager.instance.GameOver();
        }
    }

}
