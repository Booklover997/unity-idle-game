using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Logic_Script : MonoBehaviour
{
    public TMP_Text scoreText;
    public int money;
    public class item {
        public TMP_Text nameText;
        public string Name;
        public SpriteRenderer Icon;
        public int Count;
        public TMP_Text countText;
        public item(SpriteRenderer itemIcon, TMP_Text itemNameText, string itemName, int itemCount, TMP_Text itemCountText){
            nameText = itemNameText;
            Name = itemName;
            Icon = itemIcon;
            countText = itemCountText;
            Count = itemCount;
            itemCountText.text = itemCount.ToString();
            itemNameText.text = itemName.ToString();


        }
    }
    [ContextMenu("Increase Score")]
    public void addScore(){
        money += 1;
        scoreText.text = money.ToString();

    }
    
}
