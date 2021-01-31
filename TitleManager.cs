using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //コルーチンを開始
        StartCoroutine(load());
    }

    private IEnumerator load()
    {
        // 3.2秒待つ
        yield return new WaitForSeconds(3.20f);

        //MusicMakeのシーンをロード
        SceneManager.LoadScene("MusicMake");
    }
}
