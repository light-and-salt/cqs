using UnityEngine;
using System;
using System.Collections;


public class Control : MonoBehaviour {
	
	public GameObject[] GemArray = new GameObject[4];
	public static int MaxN = -1;
	private static int ObjID = -1;
	
	void Update() {
		if(Sync.NewObj == true)
		{
			// read from Sync for the new object
			print ("Got Object: " + Sync.NewObjInfo);
			// next is just instantiating... simple things...
			
			Sync.NewObj = false;
			Sync.NewObjInfo = null;
		}
		
        if (Input.GetKeyUp (KeyCode.Space))
		{
			Vector3 pos = new Vector3(UnityEngine.Random.Range(30, 50), 10, UnityEngine.Random.Range(3, 18));
			int type = UnityEngine.Random.Range(0, 4);
			GameObject NewGem;
			NewGem = Instantiate(GemArray[type], pos, Quaternion.identity) as GameObject;
			
			ObjID++;
			MaxN++;
			System.String name = Sync.prefix + "/" + ObjID;
			System.String content = "" + pos.x + "," + pos.y + "," + pos.z;
			print ("Writing " + name + " to repo: " + content);
			CCN.WriteToRepo(name, content);
		}   
    }
}
