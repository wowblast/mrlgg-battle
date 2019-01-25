using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elementalbossdeath : MonoBehaviour {

    public int Enemyhealth = 120;
    public GameObject minion;
    public GameObject caja;
    public int statuscheck;

    void Damageminion(int damage)
    {

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

            this.GetComponent<Elementalbossai>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            statuscheck = 2;
            minion.GetComponent<Animator>().Play("Death [12]");

            StartCoroutine(elimiante());
        }
    }
    IEnumerator elimiante()
    {

        yield return new WaitForSeconds(5.1f);


        Destroy(this);
        Destroy(caja);
        Destroy(minion);



    }
}
