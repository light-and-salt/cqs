using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	 void Start() {
        StartCoroutine(DoSomething());
        
        
    }
    IEnumerator DoSomething() {
        while (true) {
			yield return new WaitForSeconds(1);
            print("DoSomething Loop");
            
        }
    }
}
