using UnityEngine;
using UnityEngine.SceneManagement;  // シーンの切り替えに必要
using TMPro;                        // TextMeshProを使うのに必要
using UnityEngine.InputSystem;      // InputSystemを使うのに必要

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public string sceneName;

    // On + [アクション名]でメソッドを定義する
    void OnSubmit(InputValue value)
    {
        Load();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = GameManager.totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // シーンを読み込む
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
