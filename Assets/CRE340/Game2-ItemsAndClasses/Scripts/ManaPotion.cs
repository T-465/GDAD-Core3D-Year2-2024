using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Manapotion : Item
    {
        public int manaRestoreAmount; 
        public int minRestoreAmount = 20; 
        public int maxRestoreAmount = 50; 
                                   
        public Manapotion()
        {
            itemName = "Mana Potion";
            description = "A potion that restores mana.";
        }
        // Called when the object is instantiated
        private void Start()
        {
            // Assign a random value for manaRestoreAmount within the specified range
            manaRestoreAmount = UnityEngine.Random.Range(minRestoreAmount, maxRestoreAmount);
            Debug.Log($"ManaPotion: Random restore amount set to {manaRestoreAmount}.");
        

        }
        public override void DisplayInfo()
        {
            Debug.Log($"{itemName}: Restores {manaRestoreAmount} mana points.");
        }
    }
  

