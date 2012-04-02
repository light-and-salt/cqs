using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;


public class Sync : MonoBehaviour {

	void Start()
	{
		print(wrapper.helloworld_wrapper());
		print(wrapper.helloworld());
		//print(wrapper.saysth());
		print(wrapper.ccn_create());
		
		IntPtr cb = wrapper.ccn_charbuf_create();
		IntPtr hash = wrapper.ccn_charbuf_create();
		IntPtr nm = wrapper.ccn_charbuf_create();
		int i = 0;
		int res = 0;
		res |= wrapper.ccnb_element_begin(cb, (int)Enum.ccn_dtag.CCN_DTAG_SyncConfigSlice);
		res |= wrapper.SyncAppendTaggedNumber(cb, (int)Enum.ccn_dtag.CCN_DTAG_SyncVersion, 20120401);
		
	}
}
