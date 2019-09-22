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
        go.GetComponent<Rigidbody>().velocity = transform.up * 5.0f;
    }

    private void Start() {

  }

   private void OnEnable() {

   }
}

