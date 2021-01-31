using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    //unity上で設定
    [SerializeField] public GameObject measure1;
    [SerializeField] public GameObject measure2;
    [SerializeField] public GameObject measure3;
    [SerializeField] public GameObject measure4;
    [SerializeField] public GameObject stopButton;

    private AudioSource m1Audio;
    private AudioSource m2Audio;
    private AudioSource m3Audio;
    private AudioSource m4Audio;

    public bool play = false;//再生ボタンが押されたかどうか
    public bool stop = false;//再生ボタンが押されたかどうか
    public bool check = false;//再生ボタンが押されたかどうか

    void Update()
    {
        check = stopButton.GetComponent<StopManager>().stop;


        if(stop == true)
        {
            play = false;
            //m1Audio.Stop(m1Audio.clip);
            //m2Audio.stop(m2Audio.clip);
            //m3Audio.PlayOneShot(m3Audio.clip);
            //m4Audio.PlayOneShot(m4Audio.clip);
        }

    }

    //再生ボタンが押されたら
    public void OnClick()
    {
        //小節のAudioSouceコンポーネントを取得
        m1Audio = measure1.GetComponent<AudioSource>();
        m2Audio = measure2.GetComponent<AudioSource>();
        m3Audio = measure3.GetComponent<AudioSource>();
        m4Audio = measure4.GetComponent<AudioSource>();

        if (play == false)
        {
            //コルーチン開始、曲を鳴らす
            StartCoroutine(loop(m1Audio, m2Audio, m3Audio, m4Audio));
            play = true;
        }
    }

    private IEnumerator loop(AudioSource m1Audio, AudioSource m2Audio, AudioSource m3Audio, AudioSource m4Audio)
    {
        int n = 1;
        //パターンが挿入されている小節を鳴らす
        while (true)
        {
            if(n == 1)
            {

                m1Audio.PlayOneShot(m1Audio.clip);
                n++;
            }
            
            if(n == 2 && !m1Audio.isPlaying && check == false)
            {
                m2Audio.PlayOneShot(m2Audio.clip);
                n++;
            }

            if(n == 3 && !m2Audio.isPlaying && check == false)
            {
                m3Audio.PlayOneShot(m3Audio.clip);
                n++;
            }
            
            if(n == 4 && !m3Audio.isPlaying && check == false)
            {
                m4Audio.PlayOneShot(m4Audio.clip);
                n++;
                play = false;

            }



            if (n >= 5)
            {
                break;
            }
            // 0.01秒毎にループします
            yield return new WaitForSeconds(0.01f);

        }
        
    }
}
