using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject gabbia;
    [SerializeField] private GameObject mesh;
    [SerializeField] private GameObject canvas;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //print("ciao");
            gabbia.SetActive(false);
            mesh.SetActive(false);
            canvas.SetActive(true);
        }
    }
}
