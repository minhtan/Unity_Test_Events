using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[System.Serializable]
public class MyStringEvent : UnityEvent<string>{}

public class TestUnityEvent : MonoBehaviour {
	
	public static MyStringEvent m_MyEvent = new MyStringEvent ();

//	void Update() {
//		if (Input.anyKeyDown && m_MyEvent != null)
//		{
//			m_MyEvent.Invoke ("unity event");
//		}
//	}

	public void TestTime(){
		float time = Time.realtimeSinceStartup;
		for(int i = 0; i < 1000; i++){
			m_MyEvent.Invoke ("unity event");
		}
		Debug.Log (Time.realtimeSinceStartup - time);
	}
}
