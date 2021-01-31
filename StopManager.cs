using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopManager : MonoBehaviour
{

    [SerializeField] public GameObject measure1;
    [SerializeField] public GameObject measure2;
    [SerializeField] public GameObject measure3;
    [SerializeField] public GameObject measure4;
    [SerializeField] public GameObject playButton;

    private AudioSource m1Audio;
    private AudioSource m2Audio;
    private AudioSource m3Audio;
    private AudioSource m4Audio;

    public bool stop = false;
    public bool check = false;

    void Update()
    {
        

        check = playButton.GetComponent<MusicManager>().play;

        if(check == false)
        {
            stop = false;
        }
    }

    public void OnClick()
    {
        stop = true;

        //小節のAudioSouceコンポーネントを取得
        m1Audio = measure1.GetComponent<AudioSource>();
        m2Audio = measure2.GetComponent<AudioSource>();
        m3Audio = measure3.GetComponent<AudioSource>();
        m4Audio = measure4.GetComponent<AudioSource>();

        m1Audio.Stop();
        m2Audio.Stop();
        m3Audio.Stop();
        m4Audio.Stop();
    }
}
