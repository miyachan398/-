using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutrialManager : MonoBehaviour
{
    [SerializeField] public GameObject tutrial1;
    [SerializeField] public GameObject tutrial2;
    [SerializeField] public GameObject tutrial3;
    [SerializeField] public GameObject tutrial4;

    //操作説明のボタンが押されたらチュートリアルの画像を表示
    public void OnClick()
    {
        tutrial1.SetActive(true);
        tutrial2.SetActive(true);
        tutrial3.SetActive(true);
        tutrial4.SetActive(true);
    }
}
