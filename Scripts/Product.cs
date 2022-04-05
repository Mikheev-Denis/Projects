using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Product")]
public class Product : ScriptableObject
{
    public int amount;

    public Sprite cardImage;
    public string tag;
}

