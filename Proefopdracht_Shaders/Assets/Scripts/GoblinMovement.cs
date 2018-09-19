using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour {

    Animator Anim;
    [SerializeField]
    //private Animation running;
    //private Animation Idle;
    

	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}

    void Movement()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        if(z != 0)
        {
            Anim.SetTrigger("Idle_To_Run");
        }
        else
        {
            Anim.SetTrigger("Run_To_Idle");
        }

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    // Update is called once per frame
    void Update () {
        Movement();
	}
}
