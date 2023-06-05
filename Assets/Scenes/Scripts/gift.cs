using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("Player")) {
            Debug.Log("Gift đã va chạm với box");
        }
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("DeathZone")) {
            Debug.Log("Gift đã va chạm với DeathZone, GameOver");
        }
    }
}
