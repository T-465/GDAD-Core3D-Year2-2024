using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


    public class HealthPotion : Item
    {
        public int healthRestoreAmount; 
        public int minRestoreAmount = 30; 
        public int maxRestoreAmount = 70; 

public HealthPotion()
        {
            itemName = "Health Potion";
            description = "A potion that restores health.";
        }
        // Called when the object is instantiated
        private void Start()
        {
            // Assign a random value for healthRestoreAmount within the specified range
            healthRestoreAmount = Random.Range(minRestoreAmount, maxRestoreAmount);
            Debug.Log($"HealthPotion: Random restore amount set to {healthRestoreAmount}.");
        }
        // Override method to display specific health potion info
        public override void DisplayInfo()
        {
            Debug.Log($"{itemName}: Restores {healthRestoreAmount} health points.");
        }
    }


