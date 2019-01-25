using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiedeath : MonoBehaviour {

    public int Enemyhealth = 100;
    public GameObject minion;
    public GameObject caja;
    public int statuscheck;

    void Damageminion(int damage)
    {
        Debug.Log(Enemyhealth);
        Enemyhealth -= damage;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Enemyhealth <= 0 && statuscheck == 0)
        {

            this.GetComponent<Zombiebossai>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            statuscheck = 2;
            minion.GetComponent<Animator>().Play("Death [14]");

            StartCoroutine(elimiante());
        }
    }
    IEnumerator elimiante()
    {

        yield return new WaitForSeconds(6.1f);
        Debug.Log("murio");

        Destroy(this);
        Destroy(caja);
        Destroy(minion);



    }
}
