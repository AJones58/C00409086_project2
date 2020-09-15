using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering Trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying on Trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting Trigger");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entering Collision");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Staying on Collision");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exiting Collision");
    }
}
