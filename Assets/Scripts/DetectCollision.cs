using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameManage gameManage;

    // Start is called before the first frame update
    void Start()
    {
        gameManage=GameObject.Find("GameManager").GetComponent<GameManage>(); //update score
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
    if (other.CompareTag("Bullet")) {
        Destroy(other.gameObject);
        Destroy(gameObject);
        gameManage.UpdateScore(1);
    }
}
}
