using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GameObject.Find("Canvas/YuUtu").GetComponent<Button>();
        button.Select();
    }
}
