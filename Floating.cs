using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    Vector3 possOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    public float amplitude = 0.1f;
    public float frequency = 0.5f;

    void Start(){
        possOffset = transform.position;
    }

    private void Update() {
        tempPos = possOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}


