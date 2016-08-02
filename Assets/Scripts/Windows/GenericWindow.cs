using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class GenericWindow : MonoBehaviour {
	public static WindowManager manager;
	public GameObject firstSelected;
	protected EventSystem eventSystem{
		get{ 
			return GameObject.Find("EventSystem").GetComponent<EventSystem>();
		}
	}

	protected void Display( bool value ) {
		gameObject.SetActive( value );
	}

	public void Open(){
		Display( true );
	}

	public void Close(){
		Display( false );
	}

	protected virtual void Awake(){
		Close();
	}
}
