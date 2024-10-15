using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idamagable : MonoBehaviour
{
    public interface IDamagable
    {
        void TakeDamage(int damage);
        void ShowHitEffect();
    }


}
