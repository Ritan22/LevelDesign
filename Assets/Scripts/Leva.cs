using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leva : MonoBehaviour
{
    [SerializeField] private GameObject ponte;
    [SerializeField] private bool attivabile;

    private void Start()
    {
        attivabile = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && attivabile == true)
        {
            ponte.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            attivabile = true;
        }
        else
        {
            attivabile=false;
        }
    }
}
