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

    async void Start()
    {
        await NagatoPrints(t, "S”z‚Í‚¢‚ç‚È‚¢");
        await Task.Delay(500);

        await KyonPrints(t, "‚¨‚Ü‚¦‚ª”M‚ðo‚µ‚½‚Ì‚Íƒeƒ“ƒKƒC—Ìˆæ‚Æ‚â‚ç‚Ì‚µ‚í‚´‚È‚ñ‚¾‚ë");
        await Task.Delay(500);

        await NagatoPrints(t, "‚»‚¤");
        await Task.Delay(50);
        await NagatoPrints(t, "‚ ‚È‚½‚Æ—Á‹{ƒnƒ‹ƒq‚É‚ÍŽèo‚µ‚ð‚³‚¹‚È‚¢");
        await Task.Delay(500);

        await KyonPrints(t, "‰´‚âƒnƒ‹ƒq‚Ì‚±‚Æ‚Í‚¢‚¢‚ñ‚¾BŽ©•ª‚½‚¿‚Å‚È‚ñ‚Æ‚©‚·‚é‚µAŒ»‚É¡‚àƒsƒ“ƒsƒ“‚µ‚Ä‚éBŽèo‚µ‚³‚ê‚Ä“|‚ê‚Ä‚ñ‚Ì‚Í‚¨‚Ü‚¦‚¶‚á‚È‚¢‚©B‚â‚ß‚³‚¹‚ëB");
        await Task.Delay(500);

        await NagatoPrints(t, "‚±‚ê‚ÍŽ„‚Ì–ð–Ú‚Ìˆê‚Â    î•ñ  Žv”O‘Ì‚Í   ˆæ‚Æ‚ÌŒðM ŽŽ");
        await Task.Delay(500);

        await KyonPrints(t, "‚Ç‚¤‚µ‚½H");
        await Task.Delay(500);

        await NagatoPrints(t, "‚í‚½‚µ‚Ì‰Ò“­???????™F™L™P?åh??úx?æÁ?ö??šú??ŽÃ???’ã???úy???");
        await Task.Delay(50);
        await NagatoPrints(t, "???????“­åh????”²???’ã??‘¤??‘¤??úy??????????‘¤??");
        await Task.Delay(50);
        await NagatoPrints(t, "­‚µ–°‚é");
        await Task.Delay(5000);

        SceneManager.LoadScene("TitleScene");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == 'B') await Task.Delay(1000);
            else if (tmp[i] == 'A') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }

    async Task KyonPrints(Text t, string tmp)
    {
        t.text += "\n\nKYON> ";
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == 'B') await Task.Delay(1000);
            else if (tmp[i] == 'A') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
