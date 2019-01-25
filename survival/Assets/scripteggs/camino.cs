using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camino : MonoBehaviour
{
	public GameObject egg,egg2,egg3;
	public GameObject p1, p2, p3,luz;

	bool estado1 = false;
	bool estado2 = false;
	bool estado3 = false;
	bool estado4 = true;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if(estado4)
		{
			StartCoroutine(caminos());
			estado4 = false;
		}
		if (estado1)
		{
			egg.transform.LookAt(p1.transform);
			egg.transform.position = Vector3.MoveTowards(egg.transform.position, p1.transform.position, 0.15f);
			egg2.transform.LookAt(p2.transform);
			egg2.transform.position = Vector3.MoveTowards(egg2.transform.position, p2.transform.position, 0.15f);
			egg3.transform.LookAt(p1.transform);
			egg3.transform.position = Vector3.MoveTowards(egg3.transform.position, p1.transform.position, 0.15f);

		}
		if (estado2)
		{
			egg.transform.LookAt(p2.transform);
			egg.transform.position = Vector3.MoveTowards(egg.transform.position, p2.transform.position, 0.15f);
			egg2.transform.LookAt(p3.transform);
			egg2.transform.position = Vector3.MoveTowards(egg2.transform.position, p3.transform.position, 0.15f);
			egg3.transform.LookAt(p3.transform);
			egg3.transform.position = Vector3.MoveTowards(egg3.transform.position, p3.transform.position, 0.15f);
		}
		if (estado3)
		{
			egg.transform.LookAt(p3.transform);
			egg.transform.position = Vector3.MoveTowards(egg.transform.position, p3.transform.position, 0.15f);
			egg2.transform.LookAt(p1.transform);
			egg2.transform.position = Vector3.MoveTowards(egg2.transform.position, p1.transform.position, 0.15f);
			egg3.transform.LookAt(p2.transform);
			egg3.transform.position = Vector3.MoveTowards(egg3.transform.position, p2.transform.position, 0.15f);
		}


	}
	IEnumerator caminos()
	{
		estado1 = true;
		yield return new WaitForSeconds(1.5f);
		//egg.transform.Rotate(new Vector3(0, 60, 0));
		estado1 = false;
		estado2 = true;
		yield return new WaitForSeconds(1.5f);
		//egg.transform.Rotate(new Vector3(0, 60, 0));
		estado2 = false;
		estado3 = true;
		yield return new WaitForSeconds(1.5f);
		//egg.transform.Rotate(new Vector3(0, 60, 0));
		estado3 = false;

		
		estado4 = true;


	}
}
