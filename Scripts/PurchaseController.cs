using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseController : MonoBehaviour
{
    public Product[] shelfStock = new Product[0]; //all the products

    public Product product;

    public Image pic;

    public BackPack backPack;
    public Button button;

    public BackPack bp;
   
    void Start()
    {

        product = shelfStock[Random.Range(0, shelfStock.Length)];
        

        pic = gameObject.GetComponent<Image>();

        pic.sprite = product.cardImage; 

        button = GetComponent<Button>();


    }

    
    void Update()
    {
        backPack.breadAmount = false;
        backPack.milkAmount = false;
        backPack.sodaAmount = false;
        backPack.picklesAmount = false;
        backPack.moldedAmount = false;
        backPack.bloodAmount = false;
        backPack.inkAmount = false;
        backPack.frogsAmount = false;
    }

    public void Purchase()
    {
        if (backPack.maxAmount > backPack.currentAmount)
        {
            if (product.tag == "Bread")
            {
                backPack.breadAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Milk")
            {
                backPack.milkAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Soda")
            {
                backPack.sodaAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Pickles")
            {
                backPack.picklesAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Molded")
            {
                backPack.moldedAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Blood")
            {
                backPack.bloodAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Ink")
            {
                backPack.inkAmount = true;
                backPack.currentAmount += product.amount;
            }
            if (product.tag == "Frogs")
            {
                backPack.frogsAmount = true;
                backPack.currentAmount += product.amount;
            }

            backPack.player.mass += 0.5f;
            button.gameObject.SetActive(false);
        }
        else
        {
            backPack.full = true;
            
        }     
        
    } 
}
