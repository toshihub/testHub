using UnityEngine;
using System.Collections;

public class Test_ItemList_Launcher : MonoBehaviour {

	public GameObject cube;
	public ItemList itemlist = null;
	public string itemname = null;
	public int itemindex;


	// Use this for initialization
	void Start () {

		this.itemlist = gameObject.AddComponent<ItemList>();

		//まずリストの作成 
		//以下アイテム
		itemlist.addItem ("Lポーション",	new ItemSpec(ITEM.CLASS.LOWER,ITEM.TYPE.POTION,10f,null,
		                                     "ちょっとしか回復しない"));//0
		itemlist.addItem ("Hポーション",	new ItemSpec(ITEM.CLASS.HIGHER,ITEM.TYPE.POTION,50f,null,
		                                     "結構回復する"));//1
		itemlist.addItem ("英雄の盾",		new ItemSpec(ITEM.CLASS.HIGHER,ITEM.TYPE.SHIELD,50f,null,
		                                    "だれが英雄だと言うのか"));//2
		itemlist.addItem ("ラグナロク",		new ItemSpec(ITEM.CLASS.MIDDLE,ITEM.TYPE.SWORD,30f,null,
		                                         "だれだお前は"));
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){
			Instantiate (cube,new Vector3(Random.Range(-3.0f,3.0f),1.0f,Random.Range(-3.0f,3.0f)),Quaternion.identity);
			itemindex = Random.Range(0,4);
			itemname = itemlist.itemlist[itemindex].gettheName();
			print (itemname);

		}


//		foreach (Touch touch in Input.touches){
//			if (touch.phase == TouchPhase.Began){
//				string itemname = itemlist.itemlist[Random.Range (0,4)].gettheName();
//			//	Instantiate (cube,new Vector3(Random.Range(-3.0f,3.0f)),1.0f,Random.Range(-3.0f,3.0f)),Quaternion.identity);
//			}
//		}
	}

	void OnGUI(){
		GUI.Box(new Rect(10,10,180,180), "" + itemname);
		GUI.Box(new Rect(15,40,170,40), "" + itemlist.getItemSpec (itemindex).getItemEffect());
	}



}
