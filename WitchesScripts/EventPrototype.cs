using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "EventPrototype")]
public class EventPrototype: ScriptableObject
{
    public int food;
    public int culture;
    public int gold;
    public int material;

    public Sprite cardImage;
}
