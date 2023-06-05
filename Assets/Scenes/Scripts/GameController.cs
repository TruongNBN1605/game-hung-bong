using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject gift;
    public float spawnTime;
    private int Score { get; set; }
    public bool IsGameOver { get; set; }

    public void IncrementScore () => Score++;

    public void SpawnGift() {}


}
