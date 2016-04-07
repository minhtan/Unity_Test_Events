using UnityEngine;
using System.Collections;

public class TestCSharpEvent : MonoBehaviour {
	public delegate void MyDelegate(string msg);
	public static event MyDelegate MyEvent;

//	void Update() {
//		if (Input.anyKeyDown && MyEvent != null)
//		{
//			MyEvent ("C sharp event");
//		}
//	}

	public void TestTime(){
		float time = Time.realtimeSinceStartup;
		for(int i = 0; i < 1000; i++){
			MyEvent ("unity event");
		}
		Debug.Log (Time.realtimeSinceStartup - time);
	}
}
