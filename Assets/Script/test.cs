using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	 IEnumerator Start() {
        StartCoroutine("DoSomething", 2.0F);
        yield return new WaitForSeconds(10);
        StopCoroutine("DoSomething");
    }
    IEnumerator DoSomething(float someParameter) {
        while (true) {
			yield return new WaitForSeconds(1);
            print("DoSomething Loop");
            yield return null;
        }
    }
}
