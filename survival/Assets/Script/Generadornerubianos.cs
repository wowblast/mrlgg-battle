using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generadornerubianos : MonoBehaviour {

	public static bool start = false;
	public GameObject minion1;
	public GameObject player1;
	public bool couroutineStarted = false;
	// Update is called once per frame
	void Update()
	{

		if (start)
		{
			if (!couroutineStarted)
				StartCoroutine(crear());


		}


	}

	IEnumerator crear()
	{
		couroutineStarted = true;
		yield return new WaitForSeconds(10.1f);
		Debug.Log("creo");
		GameObject newminion = (GameObject)Instantiate(minion1);

		// accedemos al script con los valores iniciales
		minionAi ai = newminion.GetComponent<minionAi>();
		ai.player = player1;

		newminion.SetActive(true);
		couroutineStarted = false;







	}
}
