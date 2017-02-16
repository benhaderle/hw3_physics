using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject sphere;
    Vector3 lastPos;

	// Use this for initialization
	void Start () {
        lastPos = sphere.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = this.transform.position - (lastPos - sphere.transform.position);
        lastPos = sphere.transform.position;
	}
}
