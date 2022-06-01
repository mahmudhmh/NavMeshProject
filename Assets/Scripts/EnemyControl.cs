using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
  public float speed;
  private Transform target;
  private PlayerControl PlayerScript; //refer tp the script of the player
  private Animator PlayerAnm; //animation


 // Use this for initialization
 void Start () 
 
 {
  target = GameObject.FindGameObjectWithTag("Robot").GetComponent<Transform>();
  PlayerScript = GameObject.Find("Robot").GetComponent<PlayerControl>();
  PlayerAnm = GetComponent<Animator>();
 }
 
 // Update is called once per frame
 void Update () 
 
{
  if(PlayerScript.gameOver==false) // is over can't move
  {
  transform.LookAt(target.transform); //move to the target position
  transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
  PlayerAnm.SetBool("Stop",true);

  }
     
}

}
