using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubmitCreationManager : MonoBehaviour {

    [Header("Validação")]
    public ToggleGroup tglClasses;
    public ToggleGroup tglRaces;
    public Text inputName;

    PlayerCreationManager playerCreation;

	// Use this for initialization
	void Start () {
        playerCreation = GetComponent<PlayerCreationManager>();
	}

    public void SubmitPlayer() {
        if (CheckValidation())
        {
            playerCreation.SetPlayer();
            SceneManager.LoadScene(1);
        }
        else {
            playerCreation.PnlWarning.SetActive(true);
        }
    }

    public bool CheckValidation()
    {
        if (playerCreation.PlayerAux.lvlpoints > 0 || 
            tglClasses.AnyTogglesOn() == false || 
            tglRaces.AnyTogglesOn() == false ||
            inputName.text == "")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
