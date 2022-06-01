using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour
{
  public Transform Player;
     int MoveSpeed = 10;
     int MinDist = 3;
 
    void Start()
     {
 
     }
 
     void Update()
    {
        transform.LookAt(Player);
 
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
    {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
  }

    
}
 

