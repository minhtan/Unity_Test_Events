using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class AnotherScript : MonoBehaviour {
	void Start () {
		TestUnityEvent.m_MyEvent.AddListener (HandleEvent);
	}

	void HandleEvent(string msg) {
		Debug.Log ("event fired from another script with message: " + msg);
	}
}
