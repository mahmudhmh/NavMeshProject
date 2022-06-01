using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public float posx;
    public float posz;
    public int EnemyCount;
    public int WaveCount=1;

    void Start()
    {
        spawnEnemy(WaveCount);

    }
    void spawnEnemy(int numEnm){

    Vector3 pos; 
    for (int i=0;i<numEnm;i++)
     {
        pos = Randpos();
        
        Instantiate(prefab, pos , prefab.transform.rotation);
        
     }
    }

    Vector3 Randpos()
    {
        posx = Random.Range(-12,-32);
        posz = Random.Range(-30,61);
        Vector3 pos = new Vector3(posx,8,posz);
        return pos;
    }
   

    // Update is called once per frame
    void Update()
    {
     EnemyCount = FindObjectsOfType<EnemyControl>().Length;
     if (EnemyCount==0)
     {
        WaveCount++;
        spawnEnemy(WaveCount);
     }
    }
}
