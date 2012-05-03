using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;
using System.Threading;

public class trybuffer : MonoBehaviour {
	
	Thread oThread;
	
	void Start()
	{
		oThread = new Thread(new ThreadStart(TestBuf));
      	oThread.Start();
	}
	
	public void TestBuf()
	{
		CCN.testbuffer(1);
	}
	
	void Update()
	{
		if(Input.GetKeyUp (KeyCode.Q) && oThread.IsAlive )
		{
			// Request that oThread be stopped
      		oThread.Abort();
		}
	}
	
}
