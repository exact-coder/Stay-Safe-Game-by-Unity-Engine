using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public float movingSpeed;

    private Vector2 newPosition = new Vector2(15.81f, 0f);
    // private float conditionalPositionX = -16.34f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(background1.transform.position.x < conditionalPositionX){
            background1.transform.position = newPosition;
        }
        else if(background2.transform.position.x < conditionalPositionX){
            background2.transform.position = newPosition;
        }*/
        if(background2.transform.position.x <= 0){
            background1.transform.position = new Vector2(0f,0f);
            background2.transform.position = newPosition;
        }
        background1.transform.position = new Vector2(background1.transform.position.x - movingSpeed* Time.deltaTime,background1.transform.position.y);
        background2.transform.position = new Vector2(background2.transform.position.x - movingSpeed* Time.deltaTime,background2.transform.position.y);
    }
}
