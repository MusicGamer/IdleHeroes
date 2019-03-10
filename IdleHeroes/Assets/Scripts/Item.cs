using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Item", order = 2)]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public EquipmentSlot equipSlot;

    public float damageModifire;
    public float armorModifier;
}

public enum EquipmentSlot { Armor, Weapon, Accessorie }
