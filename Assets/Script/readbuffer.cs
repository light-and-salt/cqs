using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class readbuffer : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		IntPtr temp = Marshal.AllocCoTaskMem(8912);
//		CCN.ReadFromBuffer(out temp);
		string news = Marshal.PtrToStringAuto(temp);
		if(news!="")
		{
			print (news);
		}
		Marshal.FreeCoTaskMem(temp);	
	}
}
