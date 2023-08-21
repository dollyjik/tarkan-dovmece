using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public GameObject slap;
    public GameObject punch;
    public GameObject kick;

    public GameObject punchButton;
    public GameObject kickButton;

    public TextMeshProUGUI slapText;
    public TextMeshProUGUI punchText;
    public TextMeshProUGUI kickText;

    public AudioSource sound;
    
    public int slapCount = 0;
    public int punchCount = 0;
    public int kickCount = 0;

    public async void SlapButton()
    {
        slapCount++;
        slapText.text = "Tokat Sayısı : " + slapCount;
        slap.SetActive(true);
        await Task.Delay(500);
        slap.SetActive(false);
        if (slapCount == 5)
        {
            punchButton.SetActive(true);
        }
    }
    public async void PunchButton()
    {
        punchCount++;
        punchText.text = "Yumruk Sayısı : " + punchCount;
        punch.SetActive(true);
        await Task.Delay(500);
        punch.SetActive(false);
        if (punchCount == 5)
        {
            kickButton.SetActive(true);
        }
    }
    public async void KickButton()
    {
        kickCount++;
        if (kickCount == 1)
        {
            sound.Play();
        }

        kickText.text = "Tekme Sayısı : " + kickCount;
        kick.SetActive(true);
        await Task.Delay(800);
        kick.SetActive(false);
    }
}
