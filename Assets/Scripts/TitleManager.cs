using UnityEngine;
using UnityEngine.SceneManagement;  // シーンの切り替えに必要
using UnityEngine.InputSystem;      // InputSystemを使うのに必要

public class TitleManager : MonoBehaviour
{
    public string sceneName;            // 読み込むシーン名
    //public InputAction submitAction;    // 決定のInputAction

    //void OnEnable()
    //{
    //    submitAction.Enable();      // Input Actionを有効化
    //}

    //void OnDisable()
    //{
    //    submitAction.Disable();     // Input Actionを無効化
    //}

    // On + [アクション名]でメソッドを定義する
    void OnSubmit(InputValue value)
    {
        Load();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Input Actionを使った入力の取得
        //if (submitAction.WasPressedThisFrame())
        //{
        //    Load();
        //}

        //Input Deviceを使った入力の取得
        //Keyboard kb = Keyboard.current;
        //if (kb != null)
        //{
        //    if (kb.enterKey.wasPressedThisFrame)
        //    {
        //        Load();
        //    }
        //}
    }

    // シーンを読み込む
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
