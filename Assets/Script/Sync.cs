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
		if(Initialized == false)
		{
			int res = CCN.WriteSlice(prefix, topo);
			print("WriteSlice returned: " + res);
			if(res == 0)
				Initialized = true;
			else
				Debug.Log ("WriteSlice Failed. -- CQS");
		}
		
		if(Initialized == true && NewObj == false)
		{
			
		}
			 
	}
	
	
	
	/*
		
	int nextObjID = Control.MaxN + 1;
	IntPtr temp = CCN.ReadFromRepo(prefix + nextObjID);
	print ("ReadFromRepo returns: " + temp);
	System.String ObjTemp = Marshal.PtrToStringAnsi(temp);
	if(ObjTemp != null)
	{
		NewObjInfo = ObjTemp;
		NewObj = true;
	}
	
	*/
		
	
	
}
