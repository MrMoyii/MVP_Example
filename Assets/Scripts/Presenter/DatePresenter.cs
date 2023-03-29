using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DatePresenter : IDatePresenter
{
    [SerializeField] private IView view;
    [SerializeField] private Date dateModel;

    public DatePresenter(IView view)
    {
        string result;
        this.view = view;
        string dateInput = view.GetInputDate();
        
        DateTime converted_dateInput;
        dateInput = dateInput.Trim(' ');

        if (dateInput == String.Empty)
        {
            result = "Por favor, ingrese una fecha válida.";
            Show(result);
        }
        else if (TryParseInput(dateInput, out converted_dateInput))
        {   // date is correct
            dateModel = new Date(converted_dateInput);
            result = dateModel.DateIsPastPresentOrFuture();
            Show(result);
        }
        else
        {
            result = "La fecha ingresada es inválida";
            Show(result);
        }
    }

    private static bool TryParseInput(string dateInput, out DateTime converted_dateInput)
    {
        return DateTime.TryParseExact(dateInput, "dd/MM/yyyy", CultureInfo.InvariantCulture,
            DateTimeStyles.None, out converted_dateInput);
    }

    public void Show(string result)
    {
        view.DisplayResult(result);
    }

}
