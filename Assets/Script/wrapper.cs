using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;

public class wrapper : MonoBehaviour {
	
	[DllImport ("helloworld_bundle")]
	public static extern String helloworld_wrapper();
	
	[DllImport ("helloworld_bundle")]
	public static extern String helloworld();
	
	[DllImport ("CCNxPlugin")]
	public static extern IntPtr ccn_create();
	
	// ccn/charbuf.h
	[StructLayout (LayoutKind.Sequential)]
	public struct ccn_charbuf 
	{
		public IntPtr length;
    	public IntPtr limit;
    	public String buf;
	}
	
	[DllImport ("CCNxPlugin")]
	//[return: MarshalAs(UnmanagedType.LPStruct)]
	public static extern IntPtr ccn_charbuf_create();
	
	[DllImport ("CCNxPlugin")]
	public static extern int ccnb_element_begin(IntPtr c, int dtag);
	
	[DllImport ("CCNxPlugin")]
	public static extern int SyncAppendTaggedNumber(IntPtr cb, int dtag, uint val);
	
}
