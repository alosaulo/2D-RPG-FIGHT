using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

	public Collider2D InterestBoundary;

	enum SlimeStates{
		idle,
        walking,
        attacking,
		dead
	}

	SlimeStates myState;
	Collider2D playerCollider;
	// Use this for initialization
	void Start () {
		myState = SlimeStates.idle;
		playerCollider = PlayerManager._instance.Players[0].GetComponent<PlayerController>().myCollider;
	}

	// Update is called once per frame
	void Update () {
		SlimeBehavior ();
	}

	void SlimeBehavior(){
		CheckPlayerInBounds ();
		switch(myState){
			case SlimeStates.idle:
				
			break;
			case SlimeStates.walking:

			break;
			case SlimeStates.attacking:

			break;
			case SlimeStates.dead:

			break;
		}
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
            Debug.Log("Aíe");
        }
    }


    void CheckPlayerInBounds(){
		if (InterestBoundary.IsTouching(playerCollider)) {
			Debug.Log ("Estou tocando o player");
		}
	}

}
