using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]
public class Weapon : ScriptableObject
{
    public int price;
    public int damage;

    virtual public void Fire() {}
}
