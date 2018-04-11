using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScript : MonoBehaviour {
    public Text scoreTxt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreTxt.text = "Score: " +GameController.instance.score;
	}
}
