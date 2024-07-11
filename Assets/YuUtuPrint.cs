using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YuUtuPrint : MonoBehaviour
{
    public Text t;
    public ScrollRect ScrollRect;

    async void Start()
    {
        ScrollRect.verticalNormalizedPosition = 0;
        await NagatoPrints(t, "�����Ă�H");
        await Task.Delay(500);

        await KyonPrints(t, "����");
        await Task.Delay(500);

        await NagatoPrints(t, "�������̎���ԂƂ͂܂����S�ɘA����₽��Ă��Ȃ��B�ł����Ԃ̖��B�����Ȃ�΍Ō�B");
        await Task.Delay(500);

        await KyonPrints(t, "�ǂ�����Ⴂ���H");
        await Task.Delay(500);

        await NagatoPrints(t, "�ǂ��ɂ��Ȃ�Ȃ��B��񓝍��v�O�͎̂��]���Ă���B����Ői���̉\���͎���ꂽ�B");
        await Task.Delay(50);
        await NagatoPrints(t, "���{�n���q�͉����Ȃ���������𐶂ݏo���͂������Ă����B");
        await Task.Delay(50);
        await NagatoPrints(t, "����͏�񓝍��v�O�̂ɂ��Ȃ��́B���̏��n���\�͂���͂���Ύ����i���̎��������߂邩������Ȃ��ƍl�����B");
        await Task.Delay(50);
        await NagatoPrints(t, "���Ȃ��ɓq����B");
        await Task.Delay(500);

        await KyonPrints(t, "��������");
        await Task.Delay(500);

        await NagatoPrints(t, "������x������։�A���邱�Ƃ���X�͖]��ł�B���{�n���q�͏d�v�ȊĎ��ΏہB�킽���Ƃ����ő̂����Ȃ��ɂ͖߂��Ă��ė~����\n�Ɗ����Ă���B");
        await Task.Delay(50);
        await NagatoPrints(t, "�܂��}���ق�");
        await Task.Delay(50);
        await NagatoPrints(t, "sleeping deauty");
        await Task.Delay(5000);

        SceneManager.LoadScene("TitleScene");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
        ScrollRect.verticalNormalizedPosition = 0;
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '�B') await Task.Delay(1000);
            else if (tmp[i] == '�A') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }

    async Task KyonPrints(Text t, string tmp)
    {
        t.text += "\n\nKYON> ";
        ScrollRect.verticalNormalizedPosition = 0;
        t.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '�B') await Task.Delay(1000);
            else if (tmp[i] == '�A') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
