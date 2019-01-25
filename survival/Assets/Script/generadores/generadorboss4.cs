using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorboss4 : MonoBehaviour {

    // Use this for initialization
    public static bool start = false;
    public GameObject minion1;
    public GameObject player1;
    public bool couroutineStarted = false;
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

        Elementalbossai ai1 =newminion1.GetComponent<Elementalbossai>();

        ai1.player = player1;


        newminion1.SetActive(true);
        yield return new WaitForSeconds(eggpoder.nivel / 20);

        couroutineStarted = false;







    }

    private Vector3 Vector3Int(float x, float y1, float y2, Quaternion rotation)
    {
        throw new NotImplementedException();
    }
}
