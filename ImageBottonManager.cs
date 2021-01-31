using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ImageBottonManager : MonoBehaviour
{

    public Camera Camera;//main cameraを格納
    public GameObject canvas;//表示したいパターン


    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        string trueName = canvas.name;//表示したいパターンの名前

        //押したボタンのオブジェクトを取得
        GameObject imgButton = this.gameObject;
        string imgName = imgButton.name;

        Delete(trueName);//表示したいパターンを削除

        Change(imgName);//押したイメージに合うパターンの表示

    }


    //表示したいパターン以外を削除
    public void Delete(string needName)
    {

        //該当する名前のオブジェクトヒエラルキー上から取得
        GameObject enjoyPattern = GameObject.Find("EnjoyPattern");
        GameObject calmPattern = GameObject.Find("CalmPattern");
        GameObject coolPattern = GameObject.Find("CoolPattern");
        GameObject hardPattern = GameObject.Find("HardPattern");
        GameObject sadPattern = GameObject.Find("SadPattern");
        GameObject sweetPattern = GameObject.Find("SweetPattern");
        GameObject beautifulPattern = GameObject.Find("BeautifulPattern");
        GameObject painfulPattern = GameObject.Find("PainfulPattern");
        GameObject magnificentPattern = GameObject.Find("MagnificentPattern");
        GameObject creepyPattern = GameObject.Find("CreepyPattern");


        //enjoyパターンがヒエラルキー上にあれば
        if (enjoyPattern != null)
        {
            string selectName = enjoyPattern.name;

            //表示したいパターンの名前と違ったら
            if (needName != selectName)
            {
                Destroy(enjoyPattern);
            }

        }

        //calmパターンがヒエラルキー上にあれば
        if (calmPattern != null)
        {
            string selectName = calmPattern.name;

            if (needName != selectName)
            {
                Destroy(calmPattern);
            }
        }

        //coolパターンがヒエラルキー上にあれば
        if (coolPattern != null)
        {
            string selectName = coolPattern.name;

            if (needName != selectName)
            {
                Destroy(coolPattern);
            }
        }


        //hardパターンがヒエラルキー上にあれば
        if (hardPattern != null)
        {
            string selectName = hardPattern.name;

            if (needName != selectName)
            {
                Destroy(hardPattern);
            }
        }

        //sadパターンがヒエラルキー上にあれば
        if (sadPattern != null)
        {
            string selectName = sadPattern.name;

            if (needName != selectName)
            {
                Destroy(sadPattern);
            }
        }

        //sweetパターンがヒエラルキー上にあれば
        if (sweetPattern != null)
        {
            string selectName = sweetPattern.name;

            if (needName != selectName)
            {
                Destroy(sweetPattern);
            }
        }

        //beautifulパターンがヒエラルキー上にあれば
        if (beautifulPattern != null)
        {
            string selectName = beautifulPattern.name;

            if (needName != selectName)
            {
                Destroy(beautifulPattern);
            }
        }

        //painfulパターンがヒエラルキー上にあれば
        if (painfulPattern != null)
        {
            string selectName = painfulPattern.name;

            if (needName != selectName)
            {
                Destroy(painfulPattern);
            }
        }

        //magnificentパターンがヒエラルキー上にあれば
        if (magnificentPattern != null)
        {
            string selectName = magnificentPattern.name;

            if (needName != selectName)
            {
                Destroy(magnificentPattern);
            }
        }

        //creepyパターンがヒエラルキー上にあれば
        if (creepyPattern != null)
        {
            string selectName = creepyPattern.name;

            if (needName != selectName)
            {
                Destroy(creepyPattern);
            }
        }

    }


    //押されたイメージに合ったパターンを表示
    public void Change(string buttonName)
    {
        
        switch (buttonName)
        {
            case "Image1":

                GameObject pattern1 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern1.name = "EnjoyPattern";

                break;
            case "Image2":

                GameObject pattern2 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern2.name = "CalmPattern";

                break;
            case "Image3":

                GameObject pattern3 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern3.name = "CoolPattern";

                break;
            case "Image4":

                GameObject pattern4 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern4.name = "HardPattern";

                break;
            case "Image5":

                GameObject pattern5 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern5.name = "SadPattern";

                break;
            case "Image6":

                GameObject pattern6 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern6.name = "SweetPattern";

                break;
            case "Image7":

                GameObject pattern7 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern7.name = "BeautifulPattern";

                break;
            case "Image8":

                GameObject pattern8 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern8.name = "PainfulPattern";

                break;
            case "Image9":

                GameObject pattern9 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern9.name = "MagnificentPattern";

                break;
            case "Image10":

                GameObject pattern10 = (GameObject)Instantiate(canvas);
                canvas.GetComponent<Canvas>().worldCamera = Camera;//表示されるであろうパターンのcanvasをmain cameraに合わせる

                pattern10.name = "CreepyPattern";

                break;

        }

    }


    
}
