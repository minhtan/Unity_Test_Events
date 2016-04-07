using UnityEngine;
using System.Collections;

public class AnotherScript3 : MonoBehaviour {
	void Start() {
		Messenger.AddListener<string>( TestAdvancedMessenger.myEvents.testEvent1.ToString(), HandleEvent );
	}

	void HandleEvent(string msg){
		Debug.Log ("event fired from another script with message: " + msg);
	}
}
