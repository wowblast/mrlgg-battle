using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murloc3ai : MonoBehaviour {
    public GameObject minion;
    public GameObject player;
    public float enemyspeed = 0.15f;
    public bool attacktrigger = false;
    public bool isatttacking = false;
    public bool isfire = false;
    public int damage = 5;
    public float target_distance;


    // Update is called once per frame
    void Start()
    {
        minion.SetActive(true);
        player = GameObject.Find("miniongo (1)(Clone)");

    }
    void Update()
    {
        try
        {
            var heading = player.transform.position - minion.transform.position;

            transform.LookAt(player.transform);
            if (attacktrigger == false)
            {
                enemyspeed = 0.15f;
                minion.GetComponent<Animator>().Play("Run [5]");
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemyspeed);
            }
            if (30998.92 > heading.sqrMagnitude)
            {
                player = GameObject.Find("miniongo (1)(Clone)");
            }
            if (heading.sqrMagnitude < 105.9702 && isatttacking == false)
            {
                enemyspeed = 0;


                minion.GetComponent<Animator>().Play("Attack1H [2]");

                StartCoroutine(inflactdamage());
            }
        }
        catch (Exception e)
        {

            minion.GetComponent<Animator>().Play("Stand [0]");
            player = GameObject.Find("miniongo (1)(Clone)");

        }

    }
    IEnumerator inflactdamage()
    {
        isatttacking = true;
        attacktrigger = true;
        RaycastHit shot;


        isfire = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            
            target_distance = shot.distance;
            shot.transform.SendMessage("Damageminion", damage, SendMessageOptions.DontRequireReceiver);
        }
        // facedeath.Enemyhealth -= 5;
        //  shot.transform.SendMessage("Damageminion", damage, SendMessageOptions.DontRequireReceiver);


        yield return new WaitForSeconds(0.7f);
        attacktrigger = false;
        isatttacking = false;



    }
}
