using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Block") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (other.tag == "Limit") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
            }
    }
    
}
