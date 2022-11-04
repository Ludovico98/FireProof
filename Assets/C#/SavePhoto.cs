using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePhoto : MonoBehaviour
{
    public RawImage Photo;

    public void Start()
    {
        Photo.GetComponent<RawImage>().enabled = false;
    }
}
