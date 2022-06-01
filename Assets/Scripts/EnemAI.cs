using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemAI : MonoBehaviour
{
    private NavMeshAgent Mob;
    public GameObject Player;
    public float MobDistanceRun = 10;
    private PlayerControl PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        PlayerScript = GameObject.Find("Robot").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerScript.gameOver==false)
        {
            float distance = Vector3.Distance(transform.position, Player.transform.position);

            if(distance < MobDistanceRun)
            {
                Vector3 dirToPlayer = transform.position - Player.transform.position;
                Vector3 newPos = transform.position - dirToPlayer;
                Mob.SetDestination(newPos);
            }

        }
        
    }
}
