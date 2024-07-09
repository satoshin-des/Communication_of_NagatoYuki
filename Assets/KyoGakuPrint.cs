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
        await NagatoPrints(t, "�S�z�͂���Ȃ�");
        await Task.Delay(500);

        await KyonPrints(t, "���܂����M���o�����̂̓e���K�C�̈�Ƃ��̂��킴�Ȃ񂾂�");
        await Task.Delay(500);

        await NagatoPrints(t, "����");
        await Task.Delay(50);
        await NagatoPrints(t, "���Ȃ��Ɨ��{�n���q�ɂ͎�o���������Ȃ�");
        await Task.Delay(500);

        await KyonPrints(t, "����n���q�̂��Ƃ͂����񂾁B���������łȂ�Ƃ����邵�A���ɍ����s���s�����Ă�B��o������ē|��Ă�̂͂��܂�����Ȃ����B��߂�����B");
        await Task.Delay(500);

        await NagatoPrints(t, "����͎��̖�ڂ̈����������񁠁��v�O�̂́�������Ƃ̌�M����");
        await Task.Delay(500);

        await KyonPrints(t, "�ǂ������H");
        await Task.Delay(500);

        await NagatoPrints(t, "�킽���̉ғ�???????�F�L�P?�h??�x?��?��??��??��???��???�y???");
        await Task.Delay(50);
        await NagatoPrints(t, "???????���h????��???��??��??��??�y??????????��??");
        await Task.Delay(50);
        await NagatoPrints(t, "��������");
        await Task.Delay(5000);

        SceneManager.LoadScene("TitleScene");
    }


    async Task NagatoPrints(Text t, string tmp)
    {
        t.text += "\n\nYUKI.N> ";
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
        for (int i = 0; i < tmp.Length; ++i)
        {
            t.text += tmp[i];

            if (tmp[i] == '�B') await Task.Delay(1000);
            else if (tmp[i] == '�A') await Task.Delay(500);
            else await Task.Delay(100);
        }
    }
}
