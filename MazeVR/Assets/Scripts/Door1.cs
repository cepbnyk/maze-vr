using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public Key1 myKey;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (myKey.pickedUp == true)
            {
                //gameObject.SetActive(false);
                var thedoor = GameObject.FindWithTag("SF_Door1");
                thedoor.GetComponent<Animation>().Play("open");
                
            }
        }
    }
}
