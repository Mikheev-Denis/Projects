using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Card")]
public class ScriptableCard : ScriptableObject
{
    public int potions;
    public int skulls;
    public int rocks;
    public int hp;
    
    public int bombs;
    public int medicine;
    public int pebble;
    public int shield;

    public Sprite cardImage;
}
