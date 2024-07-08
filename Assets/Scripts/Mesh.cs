using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh : MonoBehaviour
{
    [SerializeField] private Camera mainCamera; // Aggiungi una variabile per la camera principale
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ottieni la posizione del mouse nel mondo 3D
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Vector3 targetPosition = hitInfo.point;

            // Calcola la direzione verso il punto del mouse
            Vector3 direction = targetPosition - transform.position;
            direction.y = 0; // Mantieni solo la componente orizzontale

            // Ruota il player verso la direzione calcolata
            if (direction != Vector3.zero)
            {
                Quaternion rotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
            }
        }
    }
}
