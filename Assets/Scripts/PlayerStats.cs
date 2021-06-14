using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    [SerializeField] private Image healthBar;

    public float Health { get => health; set => health = value; }

    

    public void SeatHealth(float h)
    {
        Health += h;
        health = Mathf.Clamp(Health, 0, 100);
        healthBar.fillAmount = Health / 100f;
        
    }
}
