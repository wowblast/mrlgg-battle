using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facebossai : MonoBehaviour {
    public GameObject minion;
    public GameObject player;
    public float enemyspeed = 0.15f;
    public bool attacktrigger = false;
    public bool isatttacking = false;

    // Update is called once per frame
    void Start()
    {
        minion.SetActive(true);

    }
    void Update()
    {
		if (Health.activos)
		{
			transform.LookAt(player.transform);
			if (attacktrigger == false)
			{
				enemyspeed = 0.15f;
				minion.GetComponent<Animator>().Play("Run [13]");
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemyspeed);
			}
			if (attacktrigger == true && isatttacking == false)
			{
				enemyspeed = 0;
				int valor = Random.Range(0, 3);

				if (valor == 0)
				{
					minion.GetComponent<Animator>().Play("AttackThrown [0]");
				}
				else if (valor == 1)
				{

					minion.GetComponent<Animator>().Play("AttackUnarmed [2]");

				}
				else if (valor == 2)
				{

					minion.GetComponent<Animator>().Play("AttackUnarmed [1]");
				}
				StartCoroutine(inflactdamage());
			}
		}
    }
    IEnumerator inflactdamage()
    {
        isatttacking = true;
        yield return new WaitForSeconds(1.1f);
        Health.currentHealth -= 100;
        yield return new WaitForSeconds(0.2f);
        isatttacking = false;


    }
    void OnTriggerEnter()
    {
        attacktrigger = true;
    }
    void OnTriggerExit()
    {
        attacktrigger = false;
    }
}
