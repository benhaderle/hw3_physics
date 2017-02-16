using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finale : MonoBehaviour {

    public GameObject Canvas;

	// Use this for initialization
	void Start () {
        Canvas.SetActive(false);
	}

    void OnTriggerEnter(Collider collider) {
        Canvas.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
