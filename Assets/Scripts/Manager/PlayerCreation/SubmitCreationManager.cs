using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitCreationManager : MonoBehaviour {

    PlayerCreationManager playerCreation;

	// Use this for initialization
	void Start () {
        playerCreation = GetComponent<PlayerCreationManager>();
	}

    public void SubmitPlayer() {
        if (playerCreation.CheckValidation())
        {
            playerCreation.SetPlayer();
            SceneManager.LoadScene(1);
        }
        else {
            playerCreation.PnlWarning.SetActive(true);
        }
    }

}
