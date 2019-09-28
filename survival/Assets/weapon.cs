using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
	public Animator ani;
	
	 public GameObject fire;
	public AudioSource fuego;
	bool isfire = false;
	public int damage = 40;
	public float target_distance;
	bool activar = true;
	

	// Use this for initialization
	void Start () {

		ani = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
		{
			disparar();
		}
		
	}
	IEnumerator Firingpistol()
	{
		RaycastHit shot;
		isfire = true;
		if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.left),out shot))
		{
			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", damage, SendMessageOptions.DontRequireReceiver);
		}
		ani.Play("BowRelease [1]");
		fire.SetActive(true);
		fire.GetComponent<Animator>().Play("fireee");
		fuego.Play();
		yield return new WaitForSeconds(0.50f);

		fire.SetActive(false);
		isfire = false;
	}

    public void disparar()
    {
        if (isfire == false)
        {
            StartCoroutine(Firingpistol());
        }
    }

}
