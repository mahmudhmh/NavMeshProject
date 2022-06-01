using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button button;
    private GameManage gameManage;
    public int difficulty;
    
   
   
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        button = GetComponent<Button>();
        gameManage = GameObject.Find("GameManager").GetComponent<GameManage>();
        button.onClick.AddListener(setDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setDifficulty()
    {
      Time.timeScale = 1;
      Debug.Log(gameObject.name + "was clicked"); 
      gameManage.StartGame(difficulty);

    }

}
