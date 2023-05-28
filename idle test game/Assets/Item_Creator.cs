using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Item_Creator : MonoBehaviour
{
    public GameObject Logic_Manager;
    public Logic_Script logic;
    public TMP_Text nameText;
    public string Name;
    public SpriteRenderer Icon;
    public int Count;
    public TMP_Text countText;
    public int increaseAmount;
    public float timeToProduce;
    public Slider ProductionSlider;
    private Logic_Script.item newItem; 
    public float FillSpeed;
    public Button BuyButton;
    public int Price;
    // Start is called before the first frame update
    void Start()
    {
        logic = Logic_Manager.GetComponent<Logic_Script>();
        newItem = new Logic_Script.item(Icon, nameText, Name, Count, countText, increaseAmount, timeToProduce, ProductionSlider, FillSpeed, BuyButton, Price);
        System.Console.WriteLine();
    }

    // Update is called once per frame
    void Update()
    {
        newItem.produce();
    }
    [ContextMenu("Increase Count")]
    public void increaseCount(){
        newItem.buy();
    }
}
