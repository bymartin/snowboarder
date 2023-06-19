using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if (collision.tag == "Ground") {
        // better way, will let you know if tag does not exist
        if (collision.CompareTag("Ground")) {
            Debug.Log("Ouch, hit my head");
        }
    }
}
