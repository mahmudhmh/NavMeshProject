using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float LeftLimit;
    public float RightLimit;
    public float DownLimit;
    public float UpLimit;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >LeftLimit){
            Destroy(gameObject);
         }
         if (transform.position.z <RightLimit){
            Destroy(gameObject);
         }
         if (transform.position.x <DownLimit){
            Destroy(gameObject);
         }
         if (transform.position.x >UpLimit){
            Destroy(gameObject);
         }
    }
}
