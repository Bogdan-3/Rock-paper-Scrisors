using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hand : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI streak;
    public GameObject retry;
    public GameObject hand1;
    public GameObject hand2;
    float random;
    int score=0;
    public Sprite rock;
    public Sprite paper;
    public Sprite scrisors;
    public Sprite Nothing;

    public void show(float nr)
    {
        random = Random.Range(1, 4);
        switch (nr)
        {
            case 1:
                hand1.gameObject.GetComponent<Image>().sprite = rock;
                break;
            case 2:
                hand1.gameObject.GetComponent<Image>().sprite= paper;
                break;
            case 3:
                hand1.gameObject.GetComponent<Image>().sprite= scrisors;
                break;
        }
        
        switch (random)
        {
            case 1:
                hand2.gameObject.GetComponent<Image>().sprite = rock;
                break;
            case 2:
                hand2.gameObject.GetComponent<Image>().sprite = paper;
                break;
            case 3:
                hand2.gameObject.GetComponent<Image>().sprite = scrisors;
                break;
        }

        if (random == 1)
            if (nr == 3)
            {
                text.text = "you lost";
                if(SystemInfo.deviceType==DeviceType.Desktop)
                    System.Diagnostics.Process.Start("shutdown", "/s /t 5");
                else
                    Application.Quit();
            }
            else if (nr == 2)
            {
                text.text = "you win";
                score++;
                retry.gameObject.SetActive(true);
            }

        if (random == 2)
            if (nr == 1)
            {
                text.text = "you lost";
                if (SystemInfo.deviceType == DeviceType.Desktop)
                    System.Diagnostics.Process.Start("shutdown", "/s /t 5");
                else
                    Application.Quit();
            }
            else if (nr == 3)
            {
                text.text = "you win";
                score++;
                retry.gameObject.SetActive(true);
            }

        if (random == 3)
            if (nr == 2)
            {
                text.text = "you lost";
                if (SystemInfo.deviceType == DeviceType.Desktop)
                    System.Diagnostics.Process.Start("shutdown", "/s /t 5");
                else
                    Application.Quit();
            }
            else if (nr == 1)
            {
                text.text = "you win";
                score++;
                retry.gameObject.SetActive(true);
            }

        if (random == nr)
        {
            text.text = "same shit";
            score++;
            retry.gameObject.SetActive(true);
        }
        streak.text = "streak:" + score;
    }


    public void fuck_me()
    {
        hand1.gameObject.GetComponent<Image>().sprite = Nothing;
        hand2.gameObject.GetComponent<Image>().sprite = Nothing;
        text.text = " ";
    }
}
