using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOption : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Instantiated;
    public GameObject NewPrefab;
    public SavingSystem savingSystem;

    private Vector3 NewPrefabPos;

    public void Instanciator()
    {
        NewPrefab = Instantiate(Prefab); //Instantiate button 
        NewPrefab.transform.SetParent(Instantiated.transform,false); 
        NewPrefab.SetActive(true);

        // setting position of instanciated prefab
        NewPrefab.transform.localPosition = NewPrefabPos;
        NewPrefabPos = new Vector3(0, NewPrefabPos.y - 60, 0);
        
        savingSystem.AddITemToLIst();
    }

    
}