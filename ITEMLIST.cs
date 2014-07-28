using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ITEM;


public class ItemList : MonoBehaviour
{
    public List<Item> itemlist;     //privateにすべきか?///////////////////////////////

    public ItemList()   //コンストラクター
    {
        this.itemlist = new List<Item>();//アイテムのリストを作成
    }

    public void addItem(string itemname, ItemSpec spec)
    {
        Item item = new Item(itemname, spec);
        itemlist.Add(item);
    }
	
	public string getItemName(int index)	//List[index]に入っているアイテムの名前をゲットしちゃおっと
	{
		Item item = this.itemlist[index];	//
		string name = item.gettheName();
		return name;
	}
	
	public ItemSpec getItemSpec(int index)	//List[index] に入っているアイテムのスペックを丸ごと返す
	{
		Item item = this.itemlist[index];
		return item.gettheSpec();
	}
	
}





/*アイテム固有の情報一つのItemクラスがアイテムの名前とItemSpecクラスにまとめられたSpec情報を持つ*/
public class Item   //一つのアイテムにつき一つのオブジェクトインスタンスを作成する
{
    private string   itemname;  //アイテム固有の名前
    private ItemSpec itemspec;  //アイテムのスペック

    public Item(string name,ItemSpec spec)
    {
        this.itemname = name;
        this.itemspec = spec;
    }
	
	public string gettheName()	//このアイテムの名前を返す 
	{
		return this.itemname;
	}
	
	public ItemSpec gettheSpec()	//このアイテムのスペックを返す
	{
		return this.itemspec;
	}
	
}

public class ItemSpec  //Itemクラスからのみのアクセスでspec情報を保持
{ 
    private string itemclass;   //アイテムの価値
    private string itemtype;    //アイテムの種類
    private float? numvalue;	//アイテム固有の効果、数値 NULLable
	private string charavalue;	//アイテム固有の効果、文字
    private string itemeffect;	//アイテムの説明、文字型 

    //ItemSpecのコンストラクタ
    public ItemSpec(CLASS itemClass,
                    TYPE itemType,
                    float? numValue,
					string charaValue,
                    string itemEffect)
    {
        itemclass	= itemClass.ToString();
        itemtype	= itemType.ToString();
        numvalue	= numValue;
		charavalue	= charaValue;
        itemeffect	= itemEffect;
    }

	public string getItemClass()
	{
		return this.itemclass;
	}

	public string getItemType()
	{
		return this.itemtype;
	}

	public float? getNumOfValue()
	{
		return this.numvalue;
	}

	public string getCharacterOfValue()
	{
		return this.charavalue;
	}

	public string getItemEffect()
	{
		return this.itemeffect;
	}
	
}