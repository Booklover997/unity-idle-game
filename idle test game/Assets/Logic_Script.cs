using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Logic_Script : MonoBehaviour
{

    public class item {
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
            if (ProductionSlider.value < TargetFill){
                ProductionSlider.value += fillSpeed * Time.deltaTime;
            }
            if (timer < timeToProduce){
            TargetFill = timer/timeToProduce;
            timer = timer + Time.deltaTime;

        }
        else
        {
            item.money += Count * increaseAmount;
            scoreText.text = item.money.ToString();
            timer = 0;
            ProductionSlider.value = 0;
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