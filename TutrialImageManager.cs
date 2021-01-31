using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutrialImageManager : MonoBehaviour
{
    [SerializeField] public GameObject tutrialImage;

    // Update is called once per frame
    public void OnClick()
    {
        tutrialImage.SetActive(false);
        
    }
}
