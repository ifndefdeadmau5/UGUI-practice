using UnityEngine;
using System.Collections;

public class StartWindow : GenericWindow {

	protected override void Awake()
	{

	}
	// Use this for initialization
	void Start () {
		Open();
	}

	public void NewGame(){
		manager.Open(1);
	}
}
