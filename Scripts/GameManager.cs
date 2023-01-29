using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private GameObjectList list;
    //Create gameobject box on space press
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject newcube = Instantiate(_cube,transform.position, transform.rotation);
            list.addItem(newcube);
        }
    }


}
