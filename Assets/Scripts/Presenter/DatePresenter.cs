using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DatePresenter : IDatePresenter
{
    [SerializeField] private IView view;
    [SerializeField] private Date dateModel;
    string result;

    public DatePresenter(IView view)
    {
        this.view = view;
        string dateInput = view.GetInputDate();
        
        DateTime converted_dateInput;
        dateInput = dateInput.Trim(' ');

        if (dateInput == String.Empty)
        {
            result = "Por favor, ingrese una fecha válida.";
            Show();
        }
        else if (TryParseInput(dateInput, out converted_dateInput))
        {   // date is correct
            dateModel = new Date(converted_dateInput);
            result = dateModel.DateIsPastPresentOrFuture();
            Show();
        }
        else
        {
            result = "La fecha ingresada es inválida";
            Show();
        }
    }

    private static bool TryParseInput(string dateInput, out DateTime converted_dateInput)
    {
        return DateTime.TryParseExact(dateInput, "dd/MM/yyyy", CultureInfo.InvariantCulture,
            DateTimeStyles.None, out converted_dateInput);
    }

    public void Show()
    {
        view.DisplayResult(result);
    }

}
