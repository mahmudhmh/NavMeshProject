using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public TextMeshProUGUI scoretest1;
    public int score1=0;
    public TextMeshProUGUI GameOverText;
    public Button RestartButton;
    public TextMeshProUGUI gameName;
    public GameObject GameName;
    public GameObject Easy;
    public GameObject Medium;
    public GameObject Hard;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void StartGame(int difficulty)
    {
        UpdateScore(0);  
        GameName.gameObject.SetActive(false);
        Easy.gameObject.SetActive(false);
        Medium.gameObject.SetActive(false);
        Hard.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    public void UpdateScore(int scoreVal)
    {
        score1 +=scoreVal;
        scoretest1.text = "KILLS: " + score1;

    }
    
}
