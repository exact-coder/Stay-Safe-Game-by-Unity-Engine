using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float enemySpeed;
    private bool hasScored;
    // Start is called before the first frame update
    void Start()
    {
        hasScored = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -7.5 && !hasScored)
        {
            GameManager.instance.score++;
            hasScored = true;
        }
        if(transform.position.x <= -9) Destroy(gameObject);

        MoveEnemy();
    }

    void MoveEnemy(){
        gameObject.transform.position = new Vector2(gameObject.transform.position.x - enemySpeed * Time.deltaTime, gameObject.transform.position.y);
    }
}
