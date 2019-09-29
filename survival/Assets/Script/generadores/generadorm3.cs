using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorm3 : MonoBehaviour {
    public GameObject minion1;
   
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



        newminion1.SetActive(true);
        newminion2.SetActive(true);

        yield return new WaitForSeconds(12);
        couroutineStarted = false;








    }

    private Vector3 Vector3Int(float x, float y1, float y2, Quaternion rotation)
    {
        throw new NotImplementedException();
    }
}
