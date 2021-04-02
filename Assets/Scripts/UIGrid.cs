using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGrid : MonoBehaviour
{
    public Image ElementImage;
    public int Elements;

    // Start is called before the first frame update
    void Awake()
    {
        for (float x = 0; x < Elements; x++ ) Instantiate(ElementImage, new Vector3(x*ElementImage.mainTexture.width, 0, 0), Quaternion.identity, transform);
    }

}
