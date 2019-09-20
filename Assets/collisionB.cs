using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionB : MonoBehaviour {
    GameObject blueberry;

    private void OnCollisionEnter2D()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
        blueberry.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
