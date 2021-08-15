using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{
    private int clickCount;
    [SerializeField]
    private Text clickCountText;

    private RandomTextGen random = new RandomTextGen();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            incriment();
        }
    }

    private void incriment()
    {
        clickCount++;
        clickCountText.text = clickCount.ToString();
        clickCountText.text = random.Generator(clickCount);
    }
}
