using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public List<GameObject> Players;
	public static PlayerManager _instance;
	// Use this for initialization
	void Start () {
		_instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
