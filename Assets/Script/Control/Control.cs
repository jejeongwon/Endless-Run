using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;



   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x <= -1.0f) return;
            
            transform.position += new Vector3(-1.5f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x >= 1.0f) return;
            transform.position += new Vector3(1.5f, 0, 0);
        }

    }

    //충돌한 물체에 대한 충돌
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Obstacle")
        {
            GameManager.instance.speed = 0;
            animator.SetTrigger("Death");
            
        }
    }

}
