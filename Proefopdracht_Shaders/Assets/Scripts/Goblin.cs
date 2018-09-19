using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour {

    private Renderer rend;
    float FatAmount = 0;

    private int _timer = 100;

	// Use this for initialization
	void Awake () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        rend.material.SetFloat("_Amount", FatAmount);

        if (FatAmount < -1)    //not valid amounts
        {
            _timer = -1; //disable timer
        }
        else if (_timer <= -1 && FatAmount >= -1){
            _timer = 100;
        }

        if (_timer == 0)
        {
            FatAmount -= 0.2f;
            _timer = 100;
        }
        else _timer -= 1;
	}
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Food")
        {
            FatAmount += 1.0f;
            Destroy(col.gameObject);
        }
    }
}
