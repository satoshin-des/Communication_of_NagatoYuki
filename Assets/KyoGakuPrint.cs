using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KyoGakuPrint : MonoBehaviour
{
    public Text t;
    public ScrollRect ScrollRect;

    async void Start()
    {
        ScrollRect.verticalNormalizedPosition = 0;
        await NagatoPrints(t, "êSîzÇÕÇ¢ÇÁÇ»Ç¢");
        await Task.Delay(500);
        
        await KyonPrints(t, "Ç®Ç‹Ç¶Ç™îMÇèoÇµÇΩÇÃÇÕÉeÉìÉKÉCóÃàÊÇ∆Ç‚ÇÁÇÃÇµÇÌÇ¥Ç»ÇÒÇæÇÎ");
        await Task.Delay(500);
        
        await NagatoPrints(t, "ÇªÇ§");
        await Task.Delay(50);
        await NagatoPrints(t, "Ç†Ç»ÇΩÇ∆ó¡ã{ÉnÉãÉqÇ…ÇÕéËèoÇµÇÇ≥ÇπÇ»Ç¢");
        await Task.Delay(500);
        
        await KyonPrints(t, "â¥Ç‚ÉnÉãÉqÇÃÇ±Ç∆ÇÕÇ¢Ç¢ÇÒÇæÅBé©ï™ÇΩÇøÇ≈Ç»ÇÒÇ∆Ç©Ç∑ÇÈÇµÅAåªÇ…ç°Ç‡ÉsÉìÉsÉìÇµÇƒÇÈÅBéËèoÇµÇ≥ÇÍÇƒì|ÇÍÇƒÇÒÇÃÇÕÇ®Ç‹Ç¶Ç∂Ç·Ç»Ç¢Ç©ÅBÇ‚ÇﬂÇ≥ÇπÇÎÅB");
        await Task.Delay(500);
        
        await NagatoPrints(t, "Ç±ÇÍÇÕéÑÇÃññ⁄ÇÃàÍÇ¬Å†Å†Å†Å†èÓïÒÅ†Å†évîOëÃÇÕÅ†Å†Å†àÊÇ∆ÇÃåêMÅ†éé");
        await Task.Delay(500);
        
        await KyonPrints(t, "Ç«Ç§ÇµÇΩÅH");
        await Task.Delay(500);
        
        await NagatoPrints(t, "ÇÌÇΩÇµÇÃâ“ì≠???????ôFôLôP?Âh??˙x?Ê¡?ùˆ??ö˙??é√???í„???˙y???");
        await Task.Delay(50);
        await NagatoPrints(t, "???????ì≠Âh????î≤???í„??ë§??ë§??˙y??????????ë§??");
        await Task.Delay(50);
        await NagatoPrints(t, "è≠Çµñ∞ÇÈ");
        await Task.Delay(5000);

        SceneManager.LoadScene("TitleScene-imp");
        //SceneManager.LoadScene("TitleScene");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        ScrollRect.verticalNormalizedPosition = 0;
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];
            t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
            ScrollRect.verticalNormalizedPosition = 0;

            if (tmp[i] == 'ÅB') await Task.Delay(1000);
            else if (tmp[i] == 'ÅA') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }

    async Task KyonPrints(Text t, string tmp)
    {
        t.text += "\n\nKYON> ";
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        ScrollRect.verticalNormalizedPosition = 0;
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];
            t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
            ScrollRect.verticalNormalizedPosition = 0;

            if (tmp[i] == 'ÅB') await Task.Delay(1000);
            else if (tmp[i] == 'ÅA') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
