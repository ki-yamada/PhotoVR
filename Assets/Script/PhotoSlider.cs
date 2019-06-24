using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSlider : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _PhotoList;

    [SerializeField]
    private SpriteRenderer _Photo;
    private int _Index;

    private void Start()
    {
        _Index = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangePhoto();
        }
    }

    private void ChangePhoto()
    {
        if (_Index >= _PhotoList.Length)
        {
            _Index = 0;
        }
        _Photo.sprite = _PhotoList[_Index];
        _Index++;

    }

}
