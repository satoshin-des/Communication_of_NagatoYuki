using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    public void YuUtu()
    {
        SceneManager.LoadScene("YuUtuScene");
    }

    public void ShoShitu()
    {
        SceneManager.LoadScene("ShoShituScene");
    }

    public void KyoGaku()
    {
        SceneManager.LoadScene("KyoGakuScene");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif (! UNITY_WEBPLAYER) && (! UNITY_WEBGL)
        Application.Quit();
#endif
    }
}
