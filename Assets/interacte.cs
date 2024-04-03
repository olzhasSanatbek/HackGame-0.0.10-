using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacte : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            float interacteRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interacteRange);
            foreach (Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out ObjectInteractable objectInteractable)) {
                    objectInteractable.Interactable();
                }
            }
        }
    }

    public ObjectInteractable GetInteractableObject() 
    {
        float interacteRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interacteRange);
            foreach (Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out ObjectInteractable objectInteractable)) {
                    return objectInteractable;
                }
            }
            return null;
    }
}
