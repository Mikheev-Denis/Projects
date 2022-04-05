using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackPack : MonoBehaviour
{ 
     public bool breadAmount;
     public bool milkAmount;
     public bool sodaAmount;
     public bool picklesAmount;

     public bool moldedAmount;
     public bool inkAmount;
     public bool bloodAmount;
     public bool frogsAmount;
    //Amount of all products

    static public int cBreadAmount;
    static public int cMilkAmount;
    static public int cSodaAmount;
    static public int cPicklesAmount;

    public int cMoldedAmount;
    public int cInkAmount;
    public int cBloodAmount;
    public int cFrogsAmount;

    //Backpack capacity
    public int maxAmount;
    public int currentAmount;

    //getting heavier
    public Rigidbody2D player;
    
    //full alert
    public Text text;
    public bool full;
    
    //HomeScreen and GameOver switch
    public GameObject gameOver;
    public GameObject homeScreen;
    //Score text
    public Text scoreText;

    void Start()
    {
        gameOver.SetActive(false);
        homeScreen.SetActive(false);
    }

    void Update()
    {
        if(full == true)
        {
            text.gameObject.SetActive(true);
        }

        text.text = "Score:" + "\n" + cBreadAmount.ToString() + " loafs" + "\n" + cMilkAmount.ToString() + " milk" + "\n" + cSodaAmount.ToString() + " soda bottles" + "\n" + cPicklesAmount.ToString() + " jam jars" + "\n" + cMoldedAmount.ToString() + " molded loafs" + "\n" + cInkAmount.ToString() + " ink" + "\n" + cBloodAmount.ToString() + " souls bottles" + "\n" + cFrogsAmount.ToString() + " jars of frogs";
    }

    public void NextDay()
    {
        
        currentAmount = 0;
        cBreadAmount--;
        cMilkAmount--;
        cSodaAmount--;
        cPicklesAmount--;

        cMoldedAmount--;
        cInkAmount--;
        cBloodAmount--;
        cFrogsAmount--;

        
        

        if(cBreadAmount <= -2 || cMilkAmount <= -2 || cSodaAmount <= -2 || cMilkAmount <= -2 || cMoldedAmount <= -2 || cInkAmount <= -2 || cBloodAmount <= -2 || cFrogsAmount <= -2)
        {
            gameOver.SetActive(true);
        }
        
    }
    
    public void AddtoBP()
    {
        if (breadAmount == true)
            cBreadAmount++;
        if (milkAmount == true)
            cMilkAmount++;
        if (sodaAmount == true)
            cSodaAmount++;
        if (picklesAmount == true)
            cPicklesAmount++;

        if (moldedAmount == true)
            cMoldedAmount++;
        if (inkAmount == true)
            cInkAmount++;
        if (bloodAmount)
            cBloodAmount++;
        if (frogsAmount == true)
            cFrogsAmount++;
    }

}
