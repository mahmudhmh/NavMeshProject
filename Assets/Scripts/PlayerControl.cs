using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float leftLimit;
    public float rightLimit;
    public float downLimit;
    public GameObject GamePrefab;
    private Rigidbody playerrg;
    public bool onGround = true;
    public float grav;
    public bool gameOver = false;
    private PlayerControl PlayerScript;
    public GameManage gameManage;
    private Animator PlayerAnm;
    public ParticleSystem Explosion;
    private AudioSource playerAudio;
    public AudioClip Die;

    // Start is called before the first frame update
    void Start()
    {
       playerrg = GetComponent<Rigidbody>();
       PlayerAnm = GetComponent<Animator>();
       Physics.gravity*= grav;
       PlayerScript = GameObject.Find("Robot").GetComponent<PlayerControl>();
       gameManage=GameObject.Find("GameManager").GetComponent<GameManage>(); 
       playerAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        if(PlayerScript.gameOver==false)
        {
         transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
         transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        }
        

        if (transform.position.z >leftLimit){
            transform.position = new Vector3 (transform.position.x, transform.position.y,leftLimit);
         }
        if (transform.position.z <rightLimit){
            transform.position = new Vector3 (transform.position.x, transform.position.y,rightLimit);
         }
         
        if (transform.position.x <downLimit){
             transform.position = new Vector3 (downLimit, transform.position.y,transform.position.z);
         }

   if(PlayerScript.gameOver==false) {

       if(Input.GetKeyDown(KeyCode.Z))
        {        
        Instantiate(GamePrefab, transform.position+(transform.forward*1), transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.Space)&& onGround)
     {
        playerrg.AddForce(Vector3.up*200, ForceMode.Impulse);
        onGround = false;
     }

    }
    
     
    }

    private void OnCollisionEnter(Collision collision) 
    {
      
      onGround = true;
      
      if (collision.gameObject.CompareTag("Enemy"))
      {
       PlayerAnm.SetBool("Run",true);
        PlayerAnm.SetTrigger("Stop");
       gameOver=true;
       //Debug.Log("Game Over");
       gameManage.GameOver();
       Explosion.Play();
       playerAudio.PlayOneShot(Die,1);
      }

      if (collision.gameObject.CompareTag("EnemyRobot"))
      {
       PlayerAnm.SetBool("Run",true);
        PlayerAnm.SetTrigger("Stop");
       gameOver=true;
       //Debug.Log("Game Over");
       gameManage.GameOver();
       Explosion.Play();
       playerAudio.PlayOneShot(Die,1);
      }
    
   }
    
}
