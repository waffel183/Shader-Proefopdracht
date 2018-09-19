using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatSpawner : MonoBehaviour {

    [SerializeField]
    GameObject Meat;

    private int _timer = 400;
    private int _currentMeat;
    private float _minSpawnX = -4.5f;
    private float _maxSpawnX = 4.5f;
    private float _minSpawnZ = -4.5f;
    private float _maxSpawnZ = 4.5f;



    // Update is called once per frame
    void Update () {
        _currentMeat = GameObject.FindGameObjectsWithTag("Food").Length;
        Debug.Log(_currentMeat);
        if (_timer == 0)
        {
            if (_currentMeat < 4)
            {
                for(int i =0; i < 4; i++)
                {
                    float randomX = Random.Range(_minSpawnX, _maxSpawnX);
                    float randomZ = Random.Range(_minSpawnZ, _maxSpawnZ);

                    Instantiate(Meat, new Vector3(randomX, 0.2f, randomZ), new Quaternion(0,0,0,0));
                }
            }
            _timer = 400;
        }
        else _timer -= 1;
        
     }
}
