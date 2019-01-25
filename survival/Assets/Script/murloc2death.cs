using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murloc2death : MonoBehaviour {
    public int Enemyhealth = 20;
    public GameObject minion;
    public GameObject caja;
    public bool statuscheck = false;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(inflactdamage());
    }

    // Update is called once per frame
    void Update()
    {


        if (statuscheck)
        {

            this.GetComponent<murloc2ai>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;


            minion.GetComponent<Animator>().Play("Death [10]");

            StartCoroutine(elimiante());
        }
    }
    IEnumerator elimiante()
    {

        yield return new WaitForSeconds(2.1f);


        Destroy(this);
        Destroy(caja);
        Destroy(minion);



    }
    IEnumerator inflactdamage()
    {

        yield return new WaitForSeconds(40.0f);
        statuscheck = true;
    }
}
