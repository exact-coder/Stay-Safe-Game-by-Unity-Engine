using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// single tune design pattern
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public Text scoreText;
    public GameObject gameOverPanel;

    void Awake() {
        instance = this;    
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+score.ToString();
    }

    public void GameOver(){
        Time.timeScale =0;
        gameOverPanel.SetActive(true);
    }

    public void OnClickPlayAgain(){
        SceneManager.LoadScene(0);
    }

    public void OnClickExit(){
        Application.Quit();
    }
}
