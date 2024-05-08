using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;

public class GlobalEventManager: MonoBehaviour
{
    public static UnityEvent<int> OnGiveDamage = new UnityEvent<int>();
    public static UnityEvent<int> GetDamage = new UnityEvent<int>();
    public static void GiveDamage(int HP, int DMG)
    {
        OnGiveDamage.Invoke(DMG);
        GetDamage.Invoke(HP);
    }

}
