using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generadornerubian : MonoBehaviour {

    public GameObject minion1;
    public GameObject player1;
    public static bool couroutineStarted = false;
    // Update is called once per frame
    void Update()
    {

        if (Health.start)
        {
            if (!couroutineStarted)
                StartCoroutine(crear());


        }


    }

    IEnumerator crear()
    {
        couroutineStarted = true;
     
        GameObject newminion1 = (GameObject)Instantiate(minion1, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        GameObject newminion2 = (GameObject)Instantiate(minion1, new Vector3(transform.position.x + 3, transform.position.y, transform.position.z), transform.rotation);
        GameObject newminion3 = (GameObject)Instantiate(minion1, new Vector3(transform.position.x - 3, transform.position.y, transform.position.z), transform.rotation);
        GameObject newminion4 = (GameObject)Instantiate(minion1, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5), transform.rotation);
        GameObject newminion5 = (GameObject)Instantiate(minion1, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5), transform.rotation);
        // accedemos al script con los valores iniciales
        Nerubianai1 ai1 = newminion1.GetComponent<Nerubianai1>();
        Nerubianai1 ai2 = newminion2.GetComponent<Nerubianai1>();
        Nerubianai1 ai3 = newminion3.GetComponent<Nerubianai1>();
        Nerubianai1 ai4 = newminion4.GetComponent<Nerubianai1>();
        Nerubianai1 ai5 = newminion5.GetComponent<Nerubianai1>();
        ai1.player = player1;
        ai2.player = player1;
        ai3.player = player1;
        ai4.player = player1;
        ai5.player = player1;

        newminion1.SetActive(true);
        newminion2.SetActive(true);
        newminion3.SetActive(true);
        newminion4.SetActive(true);
        newminion5.SetActive(true);
        yield return new WaitForSeconds(eggpoder.nivel / 90);
        couroutineStarted = false;







    }

    private Vector3 Vector3Int(float x, float y1, float y2, Quaternion rotation)
    {
        throw new NotImplementedException();
    }
}
