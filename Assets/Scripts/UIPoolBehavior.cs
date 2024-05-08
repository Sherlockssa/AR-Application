using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPoolBehavior : MonoBehaviour
{
    public static UIPoolBehavior Instance;

    public GameObject LianNiUI;

    public GameObject HuaPeiUI;

    public int ChooseNum;

    public GameObject presentStep;

    public GameObject headStep;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;
        Instance = this;
    }

    public void setPresentStep(GameObject step)
    {
        if (!presentStep)
        {
            presentStep = headStep;
        }
            presentStep.SetActive(false);
            this.presentStep = step;
        if (presentStep.transform.Find("CollectionsB") != null)
        {
            Transform[] transforms =
                presentStep.transform.Find("CollectionsB").GetComponent<CollectionBehavior>().elements;
            foreach (var transform in transforms)
            {
                Debug.Log(transform.gameObject.name);
                if (transform == transforms[ChooseNum])
                {
                    transform.gameObject.SetActive(true);
                }
                else
                {
                    transform.gameObject.SetActive(false);
                }
            }
        }
        if (presentStep.transform.Find("CollectionsA") != null)
        {
            Transform[] transforms =
                presentStep.transform.Find("CollectionsA").GetComponent<CollectionBehavior>().elements;
            foreach (var transform in transforms)
            {
                Debug.Log(transform.gameObject.name);
                if (transform == transforms[ChooseNum])
                    {
                        transform.gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.gameObject.SetActive(false);
                    }
            }
        }
        
        presentStep.SetActive(true);
        ChooseNum = 0;
    }

    public void quit()
    {
        Application.Quit();
    }
}
