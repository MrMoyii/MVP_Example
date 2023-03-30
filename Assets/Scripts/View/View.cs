using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour, IView
{
    [SerializeField] private Text result;
    [SerializeField] private InputField inputDate;
    private IDatePresenter presenter;
    public void Calculate()
    {
        presenter = new DatePresenter(this);
        presenter.Show();
    }
    public void DisplayResult(string result)
    {
        this.result.text = result;
    }

    public string GetInputDate()
    {
        return inputDate.text;
    }
}