using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameObjectList : MonoBehaviour
{
    [SerializeField]
    private ListItem _listItem;
    [SerializeField]
    private List<ListItem> _itemsList;
    [SerializeField]
    private GameObject selectAll;
    [SerializeField]
    private GameObject offVisible;
    private int instantePos = 25;
    bool isAnyOnVisible = true;
    //Initialize item list
    private void Awake(){
        _itemsList = new List<ListItem>();
    }
    //Add item to interface list
    public void addItem(GameObject gameObject){
        ListItem newItem = Instantiate(_listItem,transform.position +Vector3.down*instantePos, this.transform.rotation,this.transform);
        newItem.SetItem(gameObject);
        _itemsList.Add(newItem);
    }
    //Select all items
    public void SelectAll(){
        var isOn = selectAll.GetComponent<Toggle>().isOn;
        foreach(ListItem item in _itemsList){
            item.SetLeftToggle(isOn);
        }
    }
    //Turn on or off visibility of all items;
    public void OffVisible(){
        if (isAnyOnVisible){
            foreach(ListItem item in _itemsList){
                item.SetVisibility(0);
            }
        isAnyOnVisible = false;
        return;
        }
        else{
            foreach(ListItem item in _itemsList){
                item.SetVisibility(1);
            }
        isAnyOnVisible = true;
        return;
        }
    }
    //Changes visibility of items are selected
    public void ChangeVision(float A){
        foreach(ListItem item in _itemsList){
            if (item.IsSelected()){
                item.SetVisibility(A);
            }
        }
    }
}
