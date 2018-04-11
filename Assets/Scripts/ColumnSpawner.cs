using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {
    public GameObject column;
    public GameObject coin;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                float randomC = Random.Range(-2f, 4.3f);
                Instantiate(column, new Vector3(8, random, 0), Quaternion.identity);
                Instantiate(coin, new Vector3(4, randomC, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
        
	}
}
