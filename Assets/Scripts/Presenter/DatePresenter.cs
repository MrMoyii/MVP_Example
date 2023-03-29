using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatePresenter : IDatePresenter
{
    [SerializeField] private View view;
    [SerializeField] private Date model;
    public DatePresenter(View view)
    {
        DateTime time= DateTime.Now;
        this.view = view;
        model = new Date(time);
    }

    public void Show()
    {
        throw new System.NotImplementedException();
    }
}
