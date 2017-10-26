using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class PlayerCreationManager : MonoBehaviour
{   
    [HideInInspector]
    public GameObject PlayerGameObject;

    public PlayerPersona PlayerAux;

    public GameObject PlayerSpawn;

    public GameObject PnlWarning;

    public Text txtQntPnts;
   
    
    // Use this for initialization
    void Start () {
        
	}

    public void ChangeMainPlayer()
    {
        string playerResourceName = "Player";
        if (PlayerGameObject != null)
        {
            Destroy(PlayerGameObject);
        }
        if (PlayerAux.myClass.ClassName != "" && PlayerAux.myRace.RaceName != "")
        {   
            playerResourceName += PlayerAux.myRace.RaceName;
            playerResourceName += PlayerAux.myClass.ClassName;
            Debug.Log(playerResourceName);
            GameObject gb = Resources.Load(playerResourceName) as GameObject;
            PlayerGameObject = Instantiate(gb, PlayerSpawn.transform.position, Quaternion.identity);
            PlayerGameObject.GetComponent<PlayerController>().Speed = 0;
        }
    }

    public void SetPlayer()
    {
        PlayerGameObject.GetComponent<PlayerPersona>().SetPlayerPersona(PlayerAux);
        PlayerGameObject.GetComponent<PlayerController>().Speed = PlayerAux.myAttributes.dexterity * 1000;
    }

}
