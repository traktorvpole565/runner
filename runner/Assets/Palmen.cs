using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palmen : MonoBehaviour {

    void OnTriggerEnter(Collider other) {

        Destroy(gameObject);


        if (other.tag == "Player")
        {

            Player.instance.pelmeshki += 155;

            print(" + 1");

        }
    
    }

} 
