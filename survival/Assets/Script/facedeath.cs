using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facedeath : MonoBehaviour {
    public  int Enemyhealth = 20;
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

            this.GetComponent<faceai>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            statuscheck = 2;
            minion.GetComponent<Animator>().Play("Death [20]");

            StartCoroutine(elimiante());
        }
    }
    IEnumerator elimiante()
    {

        yield return new WaitForSeconds(1.0f);
      

        Destroy(this);
        Destroy(caja);
        Destroy(minion);



    }

}
