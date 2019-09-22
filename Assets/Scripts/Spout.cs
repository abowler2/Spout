using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spout : MonoBehaviour
{
    [SerializeField]
    private KeyCode sprayKey = KeyCode.Space;

    [SerializeField]
    private GameObject dropPrefab;

    [SerializeField]
    private Transform SpawnPoint;

    private void Update() {
        if(Input.GetKey(sprayKey)) {
            Spray();
        }
    }

    private void Spray()
    {
        GameObject go = Instantiate(dropPrefab, SpawnPoint.position, Quaternion.identity);

        Color newColor = new Color(
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f)
            );

        Color newEmissionColor = new Color(
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f),
            UnityEngine.Random.Range(0.0f, 1.0f)
            );

        go.GetComponent<Renderer>().material.SetColor("_Color", newColor);
        go.GetComponent<Renderer>().material.SetColor("_EmissionColor", newEmissionColor);


        go.GetComponent<Rigidbody>().velocity = transform.up * 5.0f;
    }

    private void Start() {

  }

   private void OnEnable() {

   }
}

