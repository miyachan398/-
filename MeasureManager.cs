using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class MeasureManager : MonoBehaviour
{

    public bool M1 = false;
    public bool M2 = false;
    public bool M3 = false;
    public bool M4 = false;

    public bool ms1 = false;
    public bool ms2 = false;
    public bool ms3 = false;
    public bool ms4 = false;

    //強調表示するための赤い枠を設定（unity上で指定）
    [SerializeField] public GameObject masterMeasure;


    public void OnClick()
    {
        //このスクリプトが付けられているオブジェクトを取得
        GameObject measureButton = this.gameObject;

        //取得したオブジェクトの名前を格納
        string measureName = measureButton.name;

        //どの小節かどうかを決める
        switch (measureName)
        {
            case "Measure1":
                if (M1 == false) {
                    M1 = true;
                    masterMeasure.SetActive(true);//選択中の小節を赤い枠を表示して協調（赤い枠はunityで設定）
                }

                if(ms1 == true)
                {
                    M1 = false;
                    ms1 = false;
                    masterMeasure.SetActive(false);//選択中の小節を赤い枠を表示して協調（赤い枠はunityで設定）
                }

                if (M1 == true)
                {
                    ms1 = true;
                }
                
                break;
            case "Measure2":
                if (M2 == false)
                {
                    M2 = true;
                    masterMeasure.SetActive(true);//選択中の小節を赤い枠を表示して協調（赤い枠はunityで設定）
                }

                if (ms2 == true)
                {
                    M2 = false;
                    ms2 = false;
                    masterMeasure.SetActive(false);//選択中の小節を赤い枠を表示して協調（赤い枠はunityで設定）
                }

                if (M2 == true)
                {
                    ms2 = true;
                }

                break;
            case "Measure3":
                if (M3 == false)
                {
                    M3 = true;
                    masterMeasure.SetActive(true);
                }

                if (ms3 == true)
                {
                    M3 = false;
                    ms3 = false;
                    masterMeasure.SetActive(false);
                }

                if (M3 == true)
                {
                    ms3 = true;
                }

                break;
            case "Measure4":
                if (M4 == false)
                {
                    M4 = true;
                    masterMeasure.SetActive(true);
                }

                if (ms4 == true)
                {
                    M4 = false;
                    ms4 = false;
                    masterMeasure.SetActive(false);
                }

                if (M4 == true)
                {
                    ms4 = true;
                }

                break;

        }

    }
}
