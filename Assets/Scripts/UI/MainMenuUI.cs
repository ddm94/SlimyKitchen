using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        // () => Lambda Expression where () is to define the params of the function, which in this case are none
        playButton.onClick.AddListener(() =>
        {
            // Click
            Loader.Load(Loader.Scene.GameScene);

        });

        quitButton.onClick.AddListener(() =>
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        });
    }
}
