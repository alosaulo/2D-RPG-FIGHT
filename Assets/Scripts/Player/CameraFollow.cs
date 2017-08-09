using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject Target;
    public float offscreenZ = 0;

    Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = new Vector3(
            Target.transform.position.x,
            Target.transform.position.y,
            offscreenZ
            );

        gameObject.transform.position = pos;

	}
}
