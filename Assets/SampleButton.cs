using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SampleButton : MonoBehaviour {

	public Button button;
	public Text nameText;
	public Text priceText;
	public Image iconImage;

	private Item item;
	private ShopScrollList scrollList;

	void Start () {
		button.onClick.AddListener (HandleClick);
	}

	public void Setup (Item currentItem, ShopScrollList currentScrollList) {
		item = currentItem;
		nameText.text = item.itemName;
		priceText.text = item.price.ToString ();
		iconImage.sprite = item.icon;

		scrollList = currentScrollList;
	}

	public void HandleClick(){
		scrollList.TryTransferItemToOtherShop (item);
	}

}
