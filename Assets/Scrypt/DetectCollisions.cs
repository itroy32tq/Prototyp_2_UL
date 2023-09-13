using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField, Range(0f, 6f)] int _hits = 2;
    [SerializeField] private Image healthBar;
    private float fill;
    private float fill_max;
    
    private void Start()
    {
        
        fill_max = _hits;

        healthBar = GetComponentInChildren<Image>();
        healthBar.fillAmount = 1f;
    }
    private void OnTriggerEnter(Collider other)
    { 
         _hits--;
        fill = _hits / fill_max;
        healthBar.fillAmount = fill;

        if (_hits < 1)
        {
            
            Destroy(gameObject);

        } 

        Destroy(other.gameObject);
    }
}
