using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;
using UnityEngine.UI;

public class CardsCollestion : MonoBehaviour
{
    public ScriptableCard[] cards = new ScriptableCard[0];

    public ScriptableCard card1;
    public ScriptableCard card2;

    public int p1Hp = 6;
    public int p2Hp = 6;

    public int p1Potion;
    public int p2Potion;

    public int p1Skull;
    public int p2Skull;

    public int p1Rock;
    public int p2Rock;

    public int p1Pebble;
    public int p2Pebble;

    public Image art1;
    public Image art2;

    public Text turnCounter;
    public bool turn;
    
    
    public void Start()
    {
        
        card1 = cards[Random.Range(0, cards.Length)];
        card2 = cards[Random.Range(0, cards.Length)];

        art1.sprite = card1.cardImage;
        art2.sprite = card2.cardImage;

    }


    public void Update()
    {
        if(turn == false)
        {
            turnCounter.text = "Player1 turn";
        }
        else
        {
            turnCounter.text = "Player2 turn";
        }
    }

    public void Card1Chooser()
    {
        if(!turn)
        {

            p1Potion += card1.potions;
            p1Rock += card1.rocks;
            p1Skull += card1.skulls;
            p1Hp -= card1.bombs;
            p1Hp += card1.medicine;
            p1Pebble += card1.pebble;

            p2Potion += card2.potions;
            p2Rock += card2.rocks;
            p2Skull += card2.skulls;
            p2Hp -= card2.bombs;
            p2Hp += card2.medicine;
            p2Pebble += card2.pebble;

            turn = true;
        }
        else
        {
           
                p1Potion += card2.potions;
                p1Rock += card2.rocks;
                p1Skull += card2.skulls;
                p1Hp -= card2.bombs;
                p1Hp += card2.medicine;
                p1Pebble += card2.pebble;
 
                p2Potion += card1.potions;
                p2Rock += card1.rocks;
                p2Skull += card1.skulls;
                p2Hp -= card1.bombs;
                p2Pebble += card1.pebble;
               

                turn = false;
            
        }
        card1 = cards[Random.Range(0, cards.Length)];
        card2 = cards[Random.Range(0, cards.Length)];

        art1.sprite = card1.cardImage;
        art2.sprite = card2.cardImage;
    }

    public void Card2Chooser()
    {
        if (!turn)
        {
            p1Potion += card2.potions;
            p1Rock += card2.rocks;
            p1Skull += card2.skulls;
            p1Hp -= card2.bombs;
            p1Hp += card2.medicine;
            p2Pebble += card2.pebble;


            p2Potion += card1.potions;
            p2Rock += card1.rocks;
            p2Skull += card1.skulls;
            p2Hp -= card1.bombs;
            p2Hp += card1.medicine;
            p2Pebble += card1.pebble;

            turn = true;
        }
        else
        {
                p1Potion += card1.potions;
                p1Rock += card1.rocks;
                p1Skull += card1.skulls;
                p1Hp -= card1.bombs;
                p1Hp += card1.medicine;
                p2Pebble += card2.pebble;

                p2Potion += card2.potions;
                p2Rock += card2.rocks;
                p2Skull += card2.skulls;
                p2Hp -= card2.bombs;
                p2Hp += card2.medicine;
                p1Pebble += card1.pebble;

                turn = false;
        }
        
        card1 = cards[Random.Range(0, cards.Length)];
        card2 = cards[Random.Range(0, cards.Length)];

        art1.sprite = card1.cardImage;
        art2.sprite = card2.cardImage;
    }
}
