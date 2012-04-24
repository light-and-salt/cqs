using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;


public class Sync : MonoBehaviour {
	
	
	public static bool NewObj = false;
	public static String NewObjInfo;
	
	private static bool Initialized = false;
	
	public static System.String prefix = "/ndn/ucla.edu/apps/cqs/game0/scene0";
	private static System.String topo = "/ndn/broadcast/cqs/game0/scene0";
	
	
	
	void Start()
	{
		int res = CCN.WriteSlice(prefix, topo);
		print("WriteSlice returned: " + res);
		if(res != 0)
		{
			Debug.Log ("WriteSlice Failed. -- CQS");
		}
		
		StartCoroutine(ReadOneObj());
				 
	}
	
	
	IEnumerator ReadOneObj() {
        while (true) {
			yield return new WaitForSeconds(1);
            
			if(NewObj == false)
			{
				int nextObjID = Control.MaxN + 1;
				System.String name = prefix + "/" + nextObjID;
				print ("Reading from repo: " + name);
				IntPtr temp = CCN.ReadFromRepo(name);
				print ("ReadFromRepo returns: " + temp);
				System.String ObjTemp = Marshal.PtrToStringAnsi(temp);
				if(ObjTemp != null)
				{
					NewObjInfo = ObjTemp;
					NewObj = true;
				}
			}
			
            
        }
    }
	
		
	
	
}
