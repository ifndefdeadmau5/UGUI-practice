using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayPlayerID : MonoBehaviour {
	Text text;
	// Use this for initialization
	void Start () {
		PlayerManager playerManager = PlayerManager.Instance;
		text = gameObject.GetComponent<Text>();
		text.text = playerManager.playerID + "Playing...";
	}
}
