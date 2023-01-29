using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ListItem : MonoBehaviour
{
    public GameObject item;
    [SerializeField]
    private GameObject toggle;
    [SerializeField]
    private GameObject visibility;
    [SerializeField]
    private GameObject objectName;

    private void Update(){
        if(item == null) Destroy(this.transform);
    }
    public void SetItem(GameObject gameObject){
        item = gameObject;
        var name = objectName.GetComponent<Text>();
        name.text = gameObject.name;
    }

    public bool IsSelected(){
        return toggle.GetComponent<Toggle>().isOn;
    }
    public void SetLeftToggle(bool isOn){
        var t = toggle.GetComponent<Toggle>();
        t.isOn = isOn;
    }
    public void SetVisibility(float a){
        var t = visibility.GetComponent<Toggle>();
        t.isOn = true ? a == 0 :false;
        var v = item.GetComponent<Renderer>();
        v.material.SetColor("_Color",new Color(v.material.color.r,v.material.color.g,v.material.color.b,a));
    }
    public void VisibilityChanged(){
        var t = visibility.GetComponent<Toggle>();
        if (t.isOn)
            SetVisibility(0);
        else SetVisibility(1);
    }
}
