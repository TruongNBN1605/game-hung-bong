using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
    public float moveSpeed;
    float xDirection;

    void Start() {
        
    }

    void Update() {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if (MathF.Abs(transform.position.x + moveStep) <= 6f)
            transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
