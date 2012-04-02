using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	
	public GameObject[] GemArray = new GameObject[4];
	
	
	void OnGUI() {
        Event e = Event.current;
        if (e.type == EventType.KeyUp && e.keyCode == KeyCode.Space)
		{
			Vector3 pos = new Vector3(Random.Range(30, 50), 10, Random.Range(3, 18));
			int type = Random.Range(0, 4);
			GameObject NewGem;
			NewGem = Instantiate(GemArray[type], pos, Quaternion.identity) as GameObject;
		}
        
    }
}
