using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternManager : MonoBehaviour
{

    protected bool first = false;//小節が１回おされたかどうか
    protected bool second = false;//小節が２回おされたかどうか

    //4つあるうちのどの小節かどうかを判別する
    private bool m1 = false;
    private bool m2 = false;
    private bool m3 = false;
    private bool m4 = false;

    private Image m1_image;
    private Image m2_image;
    private Image m3_image;
    private Image m4_image;
    
    private AudioSource m1_audio;
    private AudioSource m2_audio;
    private AudioSource m3_audio;
    private AudioSource m4_audio;


    [SerializeField] private AudioSource audioSource;

    //パターンに該当する音楽を設定（unity上で指定）
    [SerializeField] private AudioClip se;

    //パターンに該当する画像を設定（unity上で指定）
    [SerializeField] private Sprite sprite;


    //パターンのボタンが押されたら
    public void OnClick()
    {

        //該当する名前のオブジェクトヒエラルキー上から取得
        GameObject measure1 = GameObject.Find("Measure1");
        GameObject measure2 = GameObject.Find("Measure2");
        GameObject measure3 = GameObject.Find("Measure3");
        GameObject measure4 = GameObject.Find("Measure4");


        //小節に着けられたスクリプトからboolを取得
        m1 = measure1.GetComponent<MeasureManager>().M1;
        m2 = measure2.GetComponent<MeasureManager>().M2;
        m3 = measure3.GetComponent<MeasureManager>().M3;
        m4 = measure4.GetComponent<MeasureManager>().M4;

        //小節のImageコンポーネントを取得
        m1_image = measure1.GetComponent<Image>();
        m2_image = measure2.GetComponent<Image>();
        m3_image = measure3.GetComponent<Image>();
        m4_image = measure4.GetComponent<Image>();
        
        //小節のAudioSouceコンポーネントを取得
        m1_audio = measure1.GetComponent<AudioSource>();
        m2_audio = measure2.GetComponent<AudioSource>();
        m3_audio = measure3.GetComponent<AudioSource>();
        m4_audio = measure4.GetComponent<AudioSource>();




        //該当する小節に設定されている画像と曲を取得（入れ替え）
        if (m1 == true)
        {
            //m1_image = measure1.GetComponent<Image>();
            m1_image.sprite = sprite;
            m1_audio.clip = se;
            m1 = false;

        }
        
        if(m2 == true)
        {
            //m2_image = measure1.GetComponent<Image>();
            m2_image.sprite = sprite;
            m2_audio.clip = se;
            m2 = false;

        }
        
        if(m3 == true)
        {
            //m3_image = measure1.GetComponent<Image>();
            m3_image.sprite = sprite;
            m3_audio.clip = se;
            m3 = false;

        }
        
        if(m4 == true)
        {
            //m4_image = measure1.GetComponent<Image>();
            m4_image.sprite = sprite;
            m4_audio.clip = se;
            m4 = false;
        }
        
        if(m1 == false && m2 == false && m3 == false && m4 == false)
        {
            if (first == false)
            {
                first = true;
            }


            if (second == true)
            {
                audioSource.PlayOneShot(se);
                first = false;
                second = false;

            }

            if (first == true)
            {
                second = true;
            }
        }
        

        //Debug.Log(se);

    }
}
