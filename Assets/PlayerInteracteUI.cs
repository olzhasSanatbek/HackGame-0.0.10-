using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteracteUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private interacte playerInteracte;

    private void Update() 
    {
        if (playerInteracte.GetInteractableObject() != null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show() 
    {
        containerGameObject.SetActive(true);
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }

}
