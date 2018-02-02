using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

   public float moveSpeed = 0.1f;
   public float bottomOfScreen = -5f;
   public KeyCode rightKey = KeyCode.RightArrow;
   public KeyCode leftKey = KeyCode.LeftArrow;

    public string sceneOfDeath = "1";
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if(Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }

        if (transform.position.y < bottomOfScreen)
        {
            SceneManager.LoadScene(1);
        }
    }
}
