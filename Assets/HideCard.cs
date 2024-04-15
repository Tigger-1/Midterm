using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCard : MonoBehaviour
{
    public GameObject Spatial_Panel;

    private void Start()
    {
        Spatial_Panel.SetActive(false); // Set the default state of the Spatial_Panel to false
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Spatial_Panel.SetActive(true); // Activate the Spatial_Panel when the player enters
            UnityEngine.Debug.Log("Enabling");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Spatial_Panel.SetActive(false); // Deactivate the Spatial_Panel when the player exits
            UnityEngine.Debug.Log("Disabling");
        }
    }
}
