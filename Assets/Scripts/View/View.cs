using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour, IView
{
    [SerializeField] private Text result;
    [SerializeField] private IDatePresenter presenter;
    private void Start()
    {
        presenter = new DatePresenter(this);
    }

    public void DisplayResult(string result)
    {
        throw new NotImplementedException();
    }
}