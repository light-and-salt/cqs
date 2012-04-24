using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;

public class CCN : MonoBehaviour {
	
	
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
	public static extern int WriteSlice(System.String prefix, System.String topo);
	// returns 0 for success
	
	[DllImport ("CCNxPlugin")]
	public static extern IntPtr ReadFromRepo(System.String name);
		
		
	[DllImport ("CCNxPlugin")]
	public static extern void WriteToRepo(System.String name, System.String content);
	
}
