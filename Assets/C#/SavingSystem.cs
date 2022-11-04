using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BayatGames.SaveGameFree;

[System.Serializable]

public class StorageSG // no idea wha this does. do i need it ?
{
    public System.DateTime mydateTime;

    public StorageSG()
    {
        mydateTime = System.DateTime.UtcNow; // takes date and time from the device
    }

}

public class SavingSystem : MonoBehaviour
{
    public List<GameObject> floorList;
    public CreateOption createdOption;
    public GameObject ItemFromList;

    public class StorageListOption
    {

    }
    

    public string identifier = "FloorSaveData.dat";

    // When the scene it's loaded it's going to load the data.
    public void Start()
    {
        Load();
        SavingSystem data = new SavingSystem();
    }


    public void AddITemToLIst()
    {
        ItemFromList = createdOption.NewPrefab;
        floorList.Add(ItemFromList);

        Save();
        Debug.Log("Added to the list and saved  ");

    }

    public void Save()
    {
        SaveGame.Save<List<GameObject>>(identifier, floorList); //Save list item to the identifier
    }

    public void Load()
    {
         floorList = SaveGame.Load<List<GameObject>>(identifier, floorList);
         
    }

}
