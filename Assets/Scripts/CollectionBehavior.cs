using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionBehavior : MonoBehaviour
{
    private bool flag;
    public Transform[] elements;
    void Start()
    {
        flag = false;
    }

    public void NumOp(bool bl)
    {
        if (gameObject.name == "CollectionsA"&&gameObject.activeSelf)
        {
            flag = true;
            if (bl)
            {
                if (UIPoolBehavior.Instance.ChooseNum < elements.Length - 1)
                {
                    UIPoolBehavior.Instance.ChooseNum++;
                }
            }
            else
            {
                if (UIPoolBehavior.Instance.ChooseNum > 0)
                {
                    UIPoolBehavior.Instance.ChooseNum--;
                }
            }
            foreach (var element in elements)
            {
                if (element == elements[UIPoolBehavior.Instance.ChooseNum])
                {
                    element.gameObject.SetActive(true);
                }
                else
                {
                    element.gameObject.SetActive(false);
                }
            }
        }
    }
}
