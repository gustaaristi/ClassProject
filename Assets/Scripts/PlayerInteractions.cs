using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FireTag"))
        {
            Debug.Log("We hit a trap");
            playerStats.SeatHealth(-10);
        }
    }
}
