using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour {

    private LevelManager levelManager;
    
    void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
	
	void Update () {		
        if (Input.GetKeyDown(KeyCode.Return)) {
            levelManager.LoadLevel("Start");
        }
	}
}
