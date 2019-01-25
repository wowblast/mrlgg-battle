using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murloc2ai : MonoBehaviour {

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
        player = GameObject.Find("elemental1(Clone)");

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
                minion.GetComponent<Animator>().Play("Run [2]");
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemyspeed);
            }
            if (30998.92 > heading.sqrMagnitude)
            {
                player = GameObject.Find("elemental1(Clone)");
            }
            if (heading.sqrMagnitude < 480.9702 && isatttacking == false)
            {
                enemyspeed = 0;


                minion.GetComponent<Animator>().Play("AttackUnarmed [11]");

                StartCoroutine(inflactdamage());
            }
        }
        catch (Exception e)
        {

            minion.GetComponent<Animator>().Play("Stand [4]");
            player = GameObject.Find("elemental1(Clone)");

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
            shot.transform.SendMessage("Damageminion", damage , SendMessageOptions.DontRequireReceiver);
        }
        // facedeath.Enemyhealth -= 5;
        //  shot.transform.SendMessage("Damageminion", damage, SendMessageOptions.DontRequireReceiver);


        yield return new WaitForSeconds(1.0f);
        attacktrigger = false;
        isatttacking = false;



    }
}
