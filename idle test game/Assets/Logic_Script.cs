using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Logic_Script : MonoBehaviour
{

    public class item {
        //So u can drag stuff in.
        public TMP_Text nameText;
        public string Name;
        public SpriteRenderer Icon;
        public int Count;
        public TMP_Text countText;
        public int increaseAmount;
        public float timeToProduce;
        public Slider ProductionSlider;
        public static int money = 0;
        private float timer= 0;
        public float TargetFill;
        public float fillSpeed;
        public Button BuyButton;
        public int Price;
        public static TMP_Text scoreText = GameObject.FindGameObjectWithTag("MoneyText").GetComponent<TextMeshProUGUI>();

        public item(SpriteRenderer itemIcon, TMP_Text itemNameText, string itemName, int itemCount, TMP_Text itemCountText, int itemIncreaseAmount, float itemTimeToProduce, Slider itemProductionSlider, float itemFillSpeed, Button itemBuyButton, int itemPrice){
            //initialize script
            nameText = itemNameText;
            Name = itemName;
            Icon = itemIcon;
            countText = itemCountText;
            Count = itemCount;
            countText.text = Count.ToString();
            nameText.text = Name.ToString();
            increaseAmount = itemIncreaseAmount;
            timeToProduce = itemTimeToProduce;
            ProductionSlider = itemProductionSlider;
            TargetFill = 0;
            fillSpeed = itemFillSpeed;
            BuyButton = itemBuyButton;
            Price = itemPrice;
            BuyButton.onClick.AddListener(OnButtonClick);
        }
        public void OnButtonClick(){
            buy();
        }
        public void produce(){
        if (timer <= timeToProduce)
    {
        timer += Time.deltaTime;
        TargetFill = timer / timeToProduce;

    }
        else
    {
        ProductionSlider.value = 1f; // Fill the slider to maximum
        item.money += Count * increaseAmount;
        scoreText.text = item.money.ToString();
        timer = 0;
        TargetFill = 0;
        ProductionSlider.value=0;
    }
    if (ProductionSlider.value < TargetFill)
    {
        ProductionSlider.value += 1f/timeToProduce * Time.deltaTime;

    }



}
        public void buy(){
            if (item.money >= Price){
            Count +=1;
            countText.text = Count.ToString();
            item.money -= Price;
            scoreText.text = item.money.ToString();
            //TODO subtract from price
            }
            //TODO add error text 
        }
    }

    
}
// I hate chinese people