using UnityEngine;
using System.Collections;

public class AnotherScript2 : MonoBehaviour {
	void Start(){
		TestCSharpEvent.MyEvent += HandleEvent;
	}

	void HandleEvent(string msg){
		Debug.Log ("event fired from another script with message: " + msg);
	}
}
