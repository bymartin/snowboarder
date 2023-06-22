using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if (collision.tag == "Ground") {
        // better way, will let you know if tag does not exist
        if (collision.CompareTag("Ground") && !hasCrashed) {
            FindObjectOfType<PlayerController>().DisableControls();
            hasCrashed = true;
            Debug.Log("ground collision");
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
