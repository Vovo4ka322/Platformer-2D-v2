using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStealer : MonoBehaviour
{
    [SerializeField] private int _vampirismDuration = 6;

    private Health _health;

    //private IEnumerator StealHealth(EnemyMovement enemy)
    //{


    //    for (int i = 0; i < _vampirismDuration; i++)
    //    {
    //        if (enemy._health.CurrentHealth > 0)
    //        {
    //            _health.TakeHealing();
    //            _health.TakeDamage();
    //        }
    //    }
    //}
}
