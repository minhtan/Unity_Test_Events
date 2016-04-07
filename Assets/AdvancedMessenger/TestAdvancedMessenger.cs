using UnityEngine;
using System.Collections;

public class TestAdvancedMessenger : MonoBehaviour {
	public enum myEvents{
		testEvent1,
		testEvent2,
		testEvent3
	}

//	void Update() {
//		if (Input.anyKeyDown)
//		{
//			Messenger.Broadcast<string> ( myEvents.testEvent1.ToString(), "advanced messenger");
//		}
//	}

	public void TestTime(){
		float time = Time.realtimeSinceStartup;
		for(int i = 0; i < 1000; i++){
			Messenger.Broadcast<string> ( myEvents.testEvent1.ToString(), "advanced messenger");
		}
		Debug.Log (Time.realtimeSinceStartup - time);
	}
}
