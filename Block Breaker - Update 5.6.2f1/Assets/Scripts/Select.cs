using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    public AudioClip select;

    private LevelManager levelManager;
    private bool isUp = true;

    void Start() {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void Update() {
        MoveArrow();
        StartGame();
    }

    void MoveArrow() {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow)) {
            Vector3 pos = transform.position;

            if (isUp) {
                pos.y = 201;
                isUp = false;
            }
            else {
                pos.y = 250;
                isUp = true;
            }

            transform.position = pos;
            AudioSource.PlayClipAtPoint(select, new Vector3(0, 0, -10), 0.75f);
        }
    }

    void StartGame() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (isUp) {
                levelManager.LoadNextLevel();
            }
            else {
                levelManager.QuitRequest();
            }
        }
    } 
}
