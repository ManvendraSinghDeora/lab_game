using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Troop", menuName = "Scritable Object/Troop")]
public class TroopObject : ScriptableObject
{
    public new string name;
    public int Health;
    public int AttackDamage;
    public Sprite _Artwork;
}
